

namespace BDF.DVDCentral.API.Test
{
    class APIProject : WebApplicationFactory<Program>
    {
        protected override IHost CreateHost(IHostBuilder builder)
        {
            // Sharing the extra set up  
            return base.CreateHost(builder);
        }
    }

    [TestClass]
    public abstract class utBase<T> where T : class
    {
        public HttpClient client { get; }
        public Type type;

        public utBase()
        {
            var application = new APIProject();
            client = application.CreateClient();
            client.BaseAddress = new Uri(client.BaseAddress + "api/");
        }

        //[TestMethod]
        public async Task LoadTestAsync<T>(int expected)
        {
            try
            {
                dynamic items;
                Debug.Write($"Testing Load of {typeof(T).Name}: ");
                var response = await client.GetStringAsync(typeof(T).Name);
                items = (JArray)JsonConvert.DeserializeObject(response);
                List<T> values = items.ToObject<List<T>>();
                Debug.WriteLine($"{values.Count}");
                Assert.IsTrue(values.Count == expected);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error Loading {typeof(T).Name}: {ex.Message}");
                //throw;
            }
        }

        //[TestMethod]
        public async Task DeleteTestAsync<T>(Func<T, bool> filter)
        {

            Guid id = await GetId<T>(filter);

            bool rollback = true;
            HttpResponseMessage response = client.DeleteAsync(typeof(T).Name + "/" + id + "/" + rollback).Result;
            string result = response.Content.ReadAsStringAsync().Result;
            Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
            int resultValue = 0;
            foreach (var kvp in dict)
            {
                int.TryParse(kvp.Value, out resultValue);
            }
            Assert.IsTrue(resultValue > 0);

        }
        private async Task<Guid> GetId<T>(Func<T, bool> filter)
        {
            try
            {
                var response = await client.GetStringAsync(typeof(T).Name);
                dynamic items = (JArray)JsonConvert.DeserializeObject(response)!;
                List<T> values = items.ToObject<List<T>>();
                T result = values.Where(filter).FirstOrDefault()!;
                return (Guid)result.GetType().GetProperty("Id").GetValue(result, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //[TestMethod]
        public async Task InsertTestAsync<T>(T item)
        {
            bool rollback = true;
            string serializedObject = JsonConvert.SerializeObject(item);
            var content = new StringContent(serializedObject);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = client.PostAsync(typeof(T).Name + "/" + rollback, content).Result;
            string result = response.Content.ReadAsStringAsync().Result;

            // Assert that the guid is not the same as an empty guid 00000000-0000000-
            Assert.IsFalse(result.Equals(0));
        }

        //[TestMethod]
        public async Task UpdateTestAsync<T>(Func<T, bool> filter, T item)
        {
            var response1 = await client.GetStringAsync(typeof(T).Name);
            dynamic items = (JArray)JsonConvert.DeserializeObject(response1)!;
            List<T> values = items.ToObject<List<T>>();
            T result = values.Where(filter).FirstOrDefault()!;

            Guid id = (Guid)result!.GetType()!.GetProperty("Id")!.GetValue(result, null)!;
            PropertyInfo prop = item!.GetType().GetProperty("Id")!;
            prop.SetValue(item, id, null);

            // Use the item parameter to supply the updates.
            bool rollback = true;
            string serializedItem = JsonConvert.SerializeObject(item);
            var content = new StringContent(serializedItem);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = client.PutAsync(typeof(T).Name + "/" + id + "/" + rollback, content).Result;
            var results = response.Content.ReadAsStringAsync().Result;

            // Retrieve the results
            Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(results)!;
            int resultValue = 0;
            foreach (var kvp in dict)
            {
                int.TryParse(kvp.Value, out resultValue);
            }
            Debug.WriteLine($"Updated rows: {resultValue}");
            Assert.IsTrue(resultValue > 0);


        }

        //[TestMethod]
        public async Task LoadByIdTestAsync<T>(Func<T, bool> filter)
        {
            try
            {
                Guid id = await GetId<T>(filter);
                var response = client.GetStringAsync(typeof(T).Name + "/" + id).Result;
                dynamic items = JsonConvert.DeserializeObject(response)!;
                T item = items.ToObject<T>();
                Assert.AreEqual(id, item.GetType().GetProperty("Id")!.GetValue(item, null));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

        }

    }
}
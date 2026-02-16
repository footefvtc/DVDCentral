using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BDF.DVDCentral.UI.Test
{
    public class utBase
    {
        public void IndexTest<T, U>(int expected)
        {
            dynamic controller = (T)Activator.CreateInstance(typeof(T))!;
            var results = controller!.Index() as ViewResult;
            var list = (List<U>)results!.Model!;
            var count = list.Count;
            Debug.WriteLine($"Count: {typeof(T).Name.ToString()} {count}");
            Assert.AreEqual(expected, count);
        }

        public void CreateTest<T, U>(U entity)
        {
            dynamic controller = (T)Activator.CreateInstance(typeof(T))!;
            var results = controller.Create(entity, true) as RedirectToActionResult;
            Assert.AreEqual("Index", results!.ActionName);
            Debug.WriteLine($"Create: {typeof(T).Name.ToString()}");
        }

        public void DetailsTest<T, U>(string[]? searchFields = null, int id = 1)
        {
            dynamic controller = (T)Activator.CreateInstance(typeof(T))!;
            var results = controller.Details(id) as ViewResult;
            U entity = (U)results!.Model!;
            string errMessage = string.Empty;

            searchFields?.ToList<string>().ForEach(searchField =>
            {
                var value = entity?.GetType()?.GetProperty(searchField)?.GetValue(entity, null)?.ToString();
                if (value == null)
                {
                    errMessage += $"Search Field: {searchField}: {value ?? "Not found"}\n";
                    Debug.WriteLine($"Search Field: {searchField}: {value ?? "Not found"}");
                }
            });

            Assert.IsNotNull(entity);
            Assert.IsTrue(errMessage == string.Empty, errMessage);
            Debug.WriteLine($"Entity: {entity}");
        }

        public void EditTest<T, U>(int id, U entity)
        {
            dynamic controller = (T)Activator.CreateInstance(typeof(T))!;
            var results = controller.Edit(id, entity, true) as RedirectToActionResult;
            Debug.WriteLine($"Edit: {typeof(T).Name.ToString()}");
            Assert.AreEqual("Index", results!.ActionName);

        }

        public void DeleteTest<T, U>(int id)
        {
            dynamic controller = (T)Activator.CreateInstance(typeof(T))!;
            var results = controller.Delete(id, null, true) as RedirectToActionResult;
            Assert.AreEqual("Index", results!.ActionName);
            Debug.WriteLine($"Delete: {typeof(T).Name.ToString()}");
        }
    }
}
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace FVTC.Utility
{
    public static class KeyVaultClient
    {
        public static async Task<String> GetSecret(string secretName)
        {
            try
            {
                var keyVaultName = "kv-101521081-120212964";
                var kvUri = $"https://{keyVaultName}.vault.azure.net";

                var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());
                var secret = await client.GetSecretAsync(secretName);
                //Console.WriteLine(secret.Value.Value.ToString());
                return secret.Value.Value.ToString();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}

using Microsoft.Azure.Documents.Client;
using Microsoft.DataTransfer.DocumentDb.Shared;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microsoft.DataTransfer.DocumentDb.Client
{
    /// <summary>
    /// Simple DocumentDB client to verify the connection.
    /// </summary>
    public sealed class DocumentDbProbeClient
    {
        /// <summary>
        /// Tests the DocumentDB connection.
        /// </summary>
        /// <param name="connectionString">DocumentDB connection string to use to connect to the account.</param>
        /// <param name="connectionMode">DocumentDB connection mode to use when testing the connection.</param>
        /// <param name="ignoreSSLCertErrors">Determine if SSL certificate errors should be ignored when connecting to CosmosDB emulator.</param>
        /// <returns>Task that represents asynchronous connection operation.</returns>
        public async Task TestConnection(string connectionString, DocumentDbConnectionMode? connectionMode, bool? ignoreSSLCertErrors = false)
        {
            if (String.IsNullOrEmpty(connectionString))
                throw Errors.ConnectionStringMissing();

            var parsed = DocumentDbConnectionStringBuilder.Parse(connectionString);

            if (String.IsNullOrEmpty(parsed.AccountEndpoint))
                throw Errors.AccountEndpointMissing();

            if (String.IsNullOrEmpty(parsed.AccountKey))
                throw Errors.AccountKeyMissing();

            if (String.IsNullOrEmpty(parsed.Database))
                throw Errors.DatabaseNameMissing();

            var connectionPolicy =  DocumentDbClientHelper.ApplyConnectionMode(new ConnectionPolicy(), connectionMode);
            //DocumentClient client = new DocumentClient(new Uri(_endpoint), _masterKey, _handler)
            //using (DocumentClient client = new DocumentClient(new Uri("https://d-portsolapp01:8081"), "l5Hl2u2kMzUcJyFy8FShfuadO+vVCoq8VJXtFhvlypNDYMfv5vIAg7468ZMT+grV0tRUjIy55y2vte6BfOzu+Q==", DocumentDbClientHelper.GetSSLCertHandler()))

            using (var client = new DocumentClient(new Uri(parsed.AccountEndpoint), parsed.AccountKey, ignoreSSLCertErrors.GetValueOrDefault() ? DocumentDbClientHelper.GetSSLCertHandler() : null, !ignoreSSLCertErrors.GetValueOrDefault() ? connectionPolicy : null))
            {
                try
                {
                    await client.OpenAsync();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}

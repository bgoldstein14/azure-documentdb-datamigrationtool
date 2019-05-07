using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Azure.Documents.Client;
using Microsoft.DataTransfer.Basics;
using Microsoft.DataTransfer.DocumentDb.Shared;

namespace Microsoft.DataTransfer.DocumentDb.Client
{
    static class DocumentDbClientHelper
    {
        public static ConnectionPolicy ApplyConnectionMode(ConnectionPolicy connectionPolicy, DocumentDbConnectionMode? connectionMode)
        {
            Guard.NotNull("connectionPolicy", connectionPolicy);

            if (!connectionMode.HasValue)
                connectionMode = Defaults.Current.ConnectionMode;

            connectionPolicy.ConnectionMode = connectionMode == DocumentDbConnectionMode.Gateway
                ? ConnectionMode.Gateway : ConnectionMode.Direct;
            connectionPolicy.ConnectionProtocol = connectionMode == DocumentDbConnectionMode.DirectTcp
                ? Protocol.Tcp : Protocol.Https;

            return connectionPolicy;
        }

        public static HttpClientHandler GetSSLCertHandler()
        {
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            httpClientHandler.ClientCertificateOptions = ClientCertificateOption.Manual;
            httpClientHandler.ServerCertificateCustomValidationCallback += CertificateCallBack;
            return httpClientHandler;
        }

        public static bool CertificateCallBack(HttpRequestMessage a, X509Certificate2 b, X509Chain c, SslPolicyErrors d)
        {
            return true;
        }

    }
}

using System;
using System.Security.Cryptography.X509Certificates;

namespace certtest
{
    class Program
    {
        static void Main(string[] args)
        {
            X509Certificate2 cert = null;

            try
            {
                cert = new X509Certificate2("test.pfx", "abc.123");
            }
            catch (Exception e)
            {
                Console.WriteLine("Cert retrieval failed, see below for error");
                Console.WriteLine(e);
                return;
            }

            Console.WriteLine($"Hello {cert.FriendlyName}!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Reflection;
using RestSharp;
using Newtonsoft.Json;
using System.Net;


namespace Shopify_inventory


{
    internal class Program
    {

        //private static readonly HttpClient client = new HttpClient();
        static void Main(string[] args)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://172.16.101.166:80/Service1.svc/");
                //HTTP GET
                var responseTask = client.GetAsync("generar?companyPar=TEST_FEB2022&usuarioPar=Sistema03&pwsPar=ti2021&almacenPar=05");
                responseTask.Wait();

                var result = responseTask.Result;
                Console.WriteLine(result.ToString());
                if (result.IsSuccessStatusCode)
                {

                    //var readTask = result.Content.ReadAsAsync<Student[]>();
                    //readTask.Wait();

                    //var students = readTask.Result;

                    //foreach (var student in students)
                    //{
                    //    Console.WriteLine(student.Name);
                    //}
                }
            }
            Console.ReadLine();
        }

    }
}

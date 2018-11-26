using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
             void menu()
            {
                Console.Clear();
                Console.WriteLine("1. Read Clients indivual\n2. read Tours indiviual\n3. read all clients\n4. read all tours");
                System.ConsoleKeyInfo e = Console.ReadKey();;
                switch (e.KeyChar)
                {
                    case '1':
                        readClientsAsync().Wait();
                    break;
                    case '2':
                        ReadToursAsync().Wait();
                        break;
                    case '3':
                        ReadAllClientsAsync().Wait();
                        break;
                    case '4':
                        ReadAllToursAsync().Wait();
                        break;
                    default:
                        Console.WriteLine("input not recognised, 1, 2, 3 or 4 only");
                        Console.ReadLine();
                        menu();
                        break;
                }
            }

            async Task readClientsAsync()
            {
                Console.Clear();
                Console.WriteLine("Enter Client Key");
                string ClientKey = Console.ReadLine();
                Console.Clear();
                using (var client = new HttpClient())
                {
                    try
                    {
                    client.BaseAddress = new Uri("http://localhost:2650/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync("api/Clients/"+ ClientKey);
                    string newClientstring = await response.Content.ReadAsStringAsync();
                    Client newClient = JsonConvert.DeserializeObject<Client>(newClientstring);
                    Console.WriteLine("Client ID: " + newClient.Id);
                    Console.WriteLine("Client first name: " + newClient.FirstName);
                    Console.WriteLine("Client last name: " + newClient.LastName);
                    Console.WriteLine("Client address: " + newClient.Address);
                    Console.WriteLine("Client DOB: " + newClient.DateOfBirth);
                    Console.WriteLine("Client email: " + newClient.Email);
                    Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                menu();
            }

            async Task ReadToursAsync()
            {
                Console.Clear();
                Console.WriteLine("Enter Tour Key");
                string TourKey = Console.ReadLine();
                Console.Clear();
                using (var client = new HttpClient())
                {
                    try
                    {
                        client.BaseAddress = new Uri("http://localhost:2650/");
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                        HttpResponseMessage response = await client.GetAsync("api/Tours/" + TourKey);
                        string newTourString = await response.Content.ReadAsStringAsync();
                        Tour newTour = JsonConvert.DeserializeObject<Tour>(newTourString);
                        Console.WriteLine("Tour ID: " + newTour.Id);
                        Console.WriteLine("Tour start time: " + newTour.TourStartTime);
                        Console.WriteLine("Tour End Time: " + newTour.TourEndTime);
                        Console.WriteLine("Tour name: " + newTour.Name);
                        Console.WriteLine("Tour Description: " + newTour.Description);
                        Console.WriteLine("Tour Area: " + newTour.Area);
                        Console.WriteLine("Tour Location: " + newTour.Location);
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                menu();
            }

            async Task ReadAllClientsAsync()
            {
                Console.Clear();
                using (var client = new HttpClient())
                {
                    try
                    {
                        client.BaseAddress = new Uri("http://localhost:2650/");
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                        HttpResponseMessage response = await client.GetAsync("api/Clients/");
                        string newClientstring = await response.Content.ReadAsStringAsync();
                        List<Client> ClientList = JsonConvert.DeserializeObject<List<Client>>(newClientstring);
                        foreach (Client newClient in ClientList)
                        {
                            Console.WriteLine("Client ID: " + newClient.Id);
                            Console.WriteLine("Client first name: " + newClient.FirstName);
                            Console.WriteLine("Client last name: " + newClient.LastName);
                            Console.WriteLine("Client address: " + newClient.Address);
                            Console.WriteLine("Client DOB: " + newClient.DateOfBirth);
                            Console.WriteLine("Client email: " + newClient.Email);
                            Console.WriteLine("\n");
                        }
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                menu();
            }

            async Task ReadAllToursAsync()
            {
                Console.Clear();
                using (var client = new HttpClient())
                {
                    try
                    {
                        client.BaseAddress = new Uri("http://localhost:2650/");
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                        HttpResponseMessage response = await client.GetAsync("api/Tours/");
                        string newTourstring = await response.Content.ReadAsStringAsync();
                        List<Tour> TourList = JsonConvert.DeserializeObject<List<Tour>>(newTourstring);
                        foreach (Tour newTour in TourList)
                        {
                            Console.WriteLine("Tour ID: " + newTour.Id);
                            Console.WriteLine("Tour start time: " + newTour.TourStartTime);
                            Console.WriteLine("Tour End Time: " + newTour.TourEndTime);
                            Console.WriteLine("Tour name: " + newTour.Name);
                            Console.WriteLine("Tour Description: " + newTour.Description);
                            Console.WriteLine("Tour Area: " + newTour.Area);
                            Console.WriteLine("Tour Location: " + newTour.Location);
                            Console.WriteLine("\n");
                        }
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                menu();
            }

            menu();

            }
        }
    }



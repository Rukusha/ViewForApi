using ViewForApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ViewForApi.Controllers
{
    public class OrderController : Controller
    {
        string Baseurl = "https://localhost:44396";
        public async Task<ActionResult> Index()
        {

            List<Order> OrderInfo = new List<Order>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllCustomers using HttpClient  
                HttpResponseMessage Response = await client.GetAsync("api/OrdersReport");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Response.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var OrderResponse = Response.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the OrderInfo list  
                    OrderInfo = JsonConvert.DeserializeObject<List<Order>>(OrderResponse);
                }
                //returning the OrderInfo list to view  
                return View(OrderInfo);
            }
        }
    }
}
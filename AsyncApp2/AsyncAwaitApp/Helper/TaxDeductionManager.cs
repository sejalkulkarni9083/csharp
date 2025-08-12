 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AsyncAwaitDemoApp.Entities;

namespace AsyncAwaitDemoApp.Helper
{
    public static class TaxDeductionManager
    {

        //non blocking call
        //Async/Await 
        //Asynchronous method to calculate income tax

        public async static Task<string> GetAdharId(string pancardId)
        {
            // Simulate a long-running operation
            await Task.Delay(10000); // Simulating a delay of 5 seconds
            // perform some operation to get adhar id based on pan card id
            string adharId = "1234-5678-9012";//Example adhar id
            return adharId;

            //fetch secure rest api with secrete key by passing input as pan card number
            //verify the adhar number
            //verify pan card number



        }
        public static async Task<decimal> CalculateIncomeTax(decimal income)
        {
            //simulate a long-running calculation
            await Task.Delay(10000);
            //checking PN card verification of tax payer
            //verifying Adhar card identity
            //verify ITR filing details
            //After ll these verifications, we will calculate the task 

            decimal taxRate = 0.2m;
            return income * taxRate;
        }


        public async static Task<List<Product>> GetAllAvailableProducts()
        {

            // Simulate a long-running operation
            await Task.Delay(10000); // Simulating a delay of 10 seconds
                                     //perform some operation to get all available products
            List<Product> products = new List<Product>
           {
           new Product { Id = 1, Name = "Laptop", Price = 1000, Description = "High performance laptop", Category = "Electronics", Quantity = 10 },
              new Product { Id = 2, Name = "Smartphone", Price = 500, Description = "Latest model smartphone", Category = "Electronics", Quantity = 20 },
                new Product { Id = 3, Name = "Headphones", Price = 100, Description = "Noise-cancelling headphones", Category = "Electronics", Quantity = 30 }
           };
            return products;

        }

        public async static Task<string> ParallelBackgroundTasks()
        {
            Task task1 = Task.Run(() => DoWork("printing salary slips"));
            Task task2 = Task.Run(() => DoWork("sending auto generated emails to registered email ids"));
            Task task3 = Task.Run(() => DoWork("sending notification to registered mobile number"));
            Task task4 = Task.Run(() => DoWork("sending notification to registered mobile number using sms service"));

            await Task.WhenAll(task1, task2, task3, task4);
            return "All background tasks completed";
        }


        private static void DoWork(string taskName)
        {
            Console.WriteLine($"Doing Work:{taskName}");
            Thread.Sleep(5000);
            Console.WriteLine($"work completed : {taskName}");

        }

    }
}
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Coinbase.Pro.Models;
using System.Collections.Generic;
using CryptoTrading.Common.Classes;
using CryptoTrading.Common.Models.Config;

namespace CryptoTrading.TradingBot {
    class Program {
        static async Task Main(string[] args) {
            // Configure TLS 1.2
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            ConfigHandler configHandler = new("config.json");
            ConfigSettings configSettings = configHandler.GetConfigSettings();

            Console.WriteLine(configSettings.cbProAPICredentials.ApiKey);
            Console.WriteLine(configSettings.cbProAPICredentials.ApiSecret);

            //CBProClient client = new(key, secret, false);

            //while (true) {
            //    decimal price = await client.GetPrice("ETH-GBP");
            //    Console.WriteLine(price);
            //    Thread.Sleep(1000);
            //}

            
            
                
        }
    }
}


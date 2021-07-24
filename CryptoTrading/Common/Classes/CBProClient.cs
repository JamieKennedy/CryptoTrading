using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coinbase.Pro;
using Coinbase.Pro.Models;
using CryptoTrading.Common.Interfaces;

namespace CryptoTrading.Common.Classes {
    public class CBProClient : ICBProClient {

        private CoinbaseProClient Client { get; set; }

        public CBProClient(string apiKey, string apiSecret, bool sandbox) {
            if (sandbox) {
                Client = new CoinbaseProClient(new Config {
                    ApiKey = apiKey,
                    Secret = apiSecret,
                    ApiUrl = "https://api-public.sandbox.pro.coinbase.com"
                });
            }
            else {
                Client = new CoinbaseProClient(new Config {
                    ApiKey = apiKey,
                    Secret = apiSecret
                });
            }


        }

        public decimal AvgOrderBookPrice(OrderBookEntry[] orderBookEntries) {
            return orderBookEntries.Select(x => x.Price).DefaultIfEmpty(0).Average();
        }

        public async Task<decimal> GetPrice(string product, int level = 1) {
            OrderBook orderBook = await GetProductOrderBook(product, level);

            return ((AvgOrderBookPrice(orderBook.Bids) + AvgOrderBookPrice(orderBook.Asks)) / 2);
        }

        public async Task<Ticker> GetTicker(string product) {
            try {
                Ticker ticker = await Client.MarketData.GetTickerAsync(product);

                return ticker;
            }
            catch (Exception ex) {
                var errorMsg = await ex.GetErrorMessageAsync();
                return null;
            }
        }

        public async Task<List<Trade>> GetTrades(string product, int limit = 50) {
            try {
                List<Trade> trades = (await Client.MarketData.GetTradesAsync(product, limit)).Data;

                return trades;
            }
            catch (Exception ex) {
                var errorMsg = await ex.GetErrorMessageAsync();
                return null;
            }
        }

        public async Task<OrderBook> GetProductOrderBook(string product, int level = 1) {
            try {
                OrderBook orderBook = await Client.MarketData.GetOrderBookAsync(product, level);

                return orderBook;
            }
            catch (Exception ex) {
                var errorMsg = await ex.GetErrorMessageAsync();
                throw new Exception(errorMsg);
            }
        }
    }
}

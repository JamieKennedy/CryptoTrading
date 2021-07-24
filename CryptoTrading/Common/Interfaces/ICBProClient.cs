using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coinbase.Pro.Models;

namespace CryptoTrading.Common.Interfaces {
    interface ICBProClient {
        Task<Ticker> GetTicker(string product);
        Task<List<Trade>> GetTrades(string product, int limit = 50);
        Task<OrderBook> GetProductOrderBook(string product, int level = 1);
        Task<decimal> GetPrice(string product, int level = 1);
        decimal AvgOrderBookPrice(OrderBookEntry[] orderBookEntries);
    }
}

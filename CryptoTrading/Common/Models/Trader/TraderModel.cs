using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTrading.Common.Models.Trader {
    public class TraderModel {
        public long pkId { get; set; }

        public long fkAccountId { get; set; }

        public string Name { get; set; }

        public string FiatCurrency { get; set; }

        public string CryptoCurrency { get; set; }

        public decimal FiatAmount { get; set; }

        public decimal? InitialFiatAmount { get; set; }

        public decimal CryptoAmount { get; set; }

        public decimal? TakeProfit { get; set; }

        public decimal? StopLoss { get; set; }

        public decimal Result { get; set; }

        public byte[] ChangeTime { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastModified { get; set; }

    }
}

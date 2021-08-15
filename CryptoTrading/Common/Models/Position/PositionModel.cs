using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTrading.Common.Models.Position {
    public class PositionModel {
        public long pkId { get; set; }

        public long fkTraderId { get; set; }

        public string Direction { get; set; }

        public DateTime Opened { get; set; }

        public DateTime? Closed { get; set; }

        public bool IsOpen { get; set; }

        public string FiatCurrency { get; set; }

        public string CryptoCurrency { get; set; }

        public decimal OpeningFiatAmount { get; set; }

        public decimal? ClosingFiatAmount { get; set; }

        public decimal CryptoAmount { get; set; }

        public decimal? Result { get; set; }

        public byte[] ChangeTime { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastModified { get; set; }

    }
}

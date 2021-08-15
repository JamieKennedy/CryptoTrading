using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTrading.Common.Models.Account {
    public class AccountModel {
        public long pkId { get; set; }

        public decimal? GBP { get; set; }

        public decimal? EUR { get; set; }

        public decimal? USD { get; set; }

        public decimal? BTC { get; set; }

        public decimal? ETH { get; set; }

        public byte[] ChangeTime { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastModified { get; set; }
    }

}

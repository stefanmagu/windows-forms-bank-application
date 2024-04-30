using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1058_MAGUREANU_STEFAN.Entitites
{
    public class CreditAccount
    {
        public int IdAccount { get; set; }
        public int IdClient { get; set; }
        public double Sold { get; set; }
        public double LoanAmount { get; set; }
        public string OpenDate { get; set; }
        public string CloseDate { get; set; }
        public double InterestRatePerMonth { get; set; }

    }
}

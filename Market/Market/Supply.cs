using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    public class Supply
    {
        public string product;
        public DateTime date;
        public double amount;
        public double price;

        public Supply(string P, DateTime D, double A, double PRC)
        {
            product = P;
            date = D;
            amount = A;
            price = PRC;
        }
    }
}

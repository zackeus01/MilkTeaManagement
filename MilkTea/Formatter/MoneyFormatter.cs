using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTea.Formatter
{
    internal class MoneyFormatter
    {
        public MoneyFormatter() { }

        public string VNmoney(double? price)
        {
            string formattedPrice = string.Format("{0:N0} VNĐ", price);
            return formattedPrice;
        }

    }
}

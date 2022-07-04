using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPaarkingBill
{
    internal class customers
    {
        private string Customers;
        public void setCustomerName(string name)
        {
            Customers = name;
        }
        public string getCustomersNmae()
        {
            return Customers;
        }
    }
}

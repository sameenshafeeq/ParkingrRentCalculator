using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPaarkingBill
{  
    internal class parkingGarage
    {

       private string Name;
       private List<vehicles> vehicles = new List<vehicles>();
        public parkingGarage(string name)
        {
            Name = name;
        }
        public void setName(string name)
        {
            Name = name;
        }
        public string getNmae()
        {
            return Name;
        }

    }
}

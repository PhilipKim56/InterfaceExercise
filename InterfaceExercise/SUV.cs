using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : ICompany, IVehicle
    {
        public string TypeOfCargoArea { get; set; }
        public int MaxPassengers { get; set; }
        public string NameOfCompany { get; set; }
        public bool AnAmericanCompany { get ;  set ;  }
        public string DriveType { get ;  set ; }
        public int NumberOfDoors { get ;  set ; }
        public bool OffroadCapable { get ; set ;  }
        public string TypeOfFeul { get ;  set ;  }
    }
}

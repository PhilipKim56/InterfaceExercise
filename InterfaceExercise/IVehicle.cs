using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle : ICompany
    {
        public string DriveType { get; set; }
        public int NumberOfDoors { get; set; }
        public bool OffroadCapable { get; set; }
        public string TypeOfFeul { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApplication.Models
{
    public class Rental
    {
        public int RentalID { get; set; }
        public string CarModel { get; set; }
        public string CarRegistration { get; set; }

        public Rental(int _RentalID, string _CarModel, string _CarRegistration)
        {
            RentalID = _RentalID;
            CarModel = _CarModel;
            CarRegistration = _CarRegistration;
        }

        public Rental()
        {

        }
    }
}

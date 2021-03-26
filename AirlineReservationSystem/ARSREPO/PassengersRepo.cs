using ARSDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARSREPO
{
    public class PassengersRepo:IPassengers
    {
        ARSEntities db = new ARSEntities();
        public void AddLogin(Passenger obj)
        {
            db.Passengers.Add(obj);
            db.SaveChanges();

        }

       

        public Passenger ValidatePassenger(string Name, string Password)
        {
            Passenger l = db.Passengers.Where(a => a.Name.Equals(Name) && a.Password.Equals(Password)).FirstOrDefault();
            return l;
        }

        

        int IPassengers.AddLogin(Passenger obj)
        {
            throw new NotImplementedException();
        }
    }
}

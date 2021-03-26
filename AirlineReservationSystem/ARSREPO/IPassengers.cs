using ARSDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARSREPO
{
    public interface IPassengers
    {
        Passenger ValidatePassenger(string Name, string Password);
        int AddLogin(Passenger obj);
    }
}

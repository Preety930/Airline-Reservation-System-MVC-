using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARSDAL;
namespace ARSREPO
{
    public interface IAdmin
    {
        Admin ValidateAdmin(string Name, string Password);
        int AddLogin(Admin obj);
    }
}

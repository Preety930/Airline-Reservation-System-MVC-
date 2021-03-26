using ARSDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARSREPO
{
     public class AdminRepo : IAdmin
    {
        ARSEntities db = new ARSEntities();
        public void AddLogin(Admin obj)
        {
            db.Admins.Add(obj);
            db.SaveChanges();
            
        }

        public Admin ValidateAdmin(string Name, string Password)
        {
            Admin l=db.Admins.Where(a => a.Name.Equals(Name) && a.Password.Equals(Password)).FirstOrDefault();
           return l;
                }

        int IAdmin.AddLogin(Admin obj)
        {
            throw new NotImplementedException();
        }
    }
}

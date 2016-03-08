using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBEntities;

namespace DBAccess.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Dba dba = new Dba(new UserControl());

            User user = new User();
            user.Name.FirstName = "Mr. ";
            user.Name.MiddelName = "Derp ";
            user.Name.LastName = "Andersen";

            dba.UserControl.Add(user);
        }
    }
}

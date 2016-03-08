using System.ComponentModel;
using DBEntities;
using Microsoft.Win32;

namespace DBAccess
{
    public class Dba
    {
        public IUserControl UserControl { get; private set; }

        public Dba(IUserControl userControl)
        {
            UserControl = userControl;
        }
    }

    public interface IUserControl
    {
        void Add(User user);
    }

    public class UserControl : IUserControl
    {
        public void Add(User user)
        {
            using (var db = new SPEntityModelContainer())
            {
                db.Users.Add(user);
                //db.Names.Add(user.Name);
            }
        }
    }
}

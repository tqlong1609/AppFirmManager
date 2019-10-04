using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCinema.ObjectFolder
{
    public class TypeLogin
    {
        public static ETypeLogin typeLogin = ETypeLogin.guest;
    }
    public enum ETypeLogin
    {
        user, manager, admin, guest
    }
}

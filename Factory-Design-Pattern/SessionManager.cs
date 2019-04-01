using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    //Singleton 
    public class SessionManager
    {
        private static SessionManager _utility;

        private SessionManager(){ }

        public static SessionManager GetInstance()
        {
            if (_utility == null)
                _utility = new SessionManager();
            return _utility;
        }
   
    }
}

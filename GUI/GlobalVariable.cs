using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class GlobalVariable
    {
        private static string _userID;

        public static string UserID
        {
            get
            { 
                return _userID;
            }

            set
            {
                _userID = value;
            }
        }
    }
}

using Final_Project.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class GetSet
    {
        private static GetSet _instance;


        // *********** Member 
        public USERACCOUNT UserAccount { get; set; }


        //************
        private GetSet()
        {

        }

        public static GetSet GetInstance()
        {
            if (_instance == null)
                _instance = new GetSet();
            return _instance;
        }
    }
}

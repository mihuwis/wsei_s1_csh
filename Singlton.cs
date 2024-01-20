using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProject02
{
    internal class Singlton
    {


        static Singlton _instance;

        public Singlton GetSinglton()
        {
            if (_instance == null)
            {
                _instance = new Singlton();
            }
            return _instance;
        }
    }
}

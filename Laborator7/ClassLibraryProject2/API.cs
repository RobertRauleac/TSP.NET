using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{

    public class API : Interface1
    {
        public object Class1 { get; private set; }

        void Interface1.Insert(string name, double size, string path, string format, DateTime date)
        {
            Class1.Insert(string name, double size, string path, string format, DateTime date);
        }

        void Interface1.Delete(string par)
        {
            Class1.Delete(string par)
        }

        void Interface1.newCol(string par)
        {
            Class1.newCol(string par)
        }

        void Interface1.deleteCol(string par)
        {
            Class1.deleteCol(string par)
        }

        void Interface1.Update(string path, string column, string value)
        {
            Class1.Update(string path, string column, string value)
        }


    }
    
}

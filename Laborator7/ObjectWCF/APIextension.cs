using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryProject;

namespace ObjectWCF
{
    public class APIextension : Interface
    {

        void Interface.Insert(string name, double size, string path, string format, DateTime date)
        {
            Class1.Insert( name,  size,  path,  format,  date);
        }

        void Interface.Delete(string par)
        {
            Class1.Delete( par);
        }

        void Interface.newCol(string par)
        {
            Class1.newCol( par);
        }

        void Interface.deleteCol(string par)
        {
            Class1.deleteCol( par);
        }

        void Interface.Update(string path, string column, string value)
        {
            Class1.Update( path,  column,  value);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryProject;

namespace ObjectWCF
{
    public class APIextension : Interface1
    {

        void Interface1.Insert(string name, double size, string path, string format, DateTime date)
        {
            Class1.Insert( name,  size,  path,  format,  date);
        }

        void Interface1.Delete(string par)
        {
            Class1.Delete( par);
        }

        void Interface1.newCol(string par)
        {
            Class1.newCol( par);
        }

        void Interface1.deleteCol(string par)
        {
            Class1.deleteCol( par);
        }

        void Interface1.Update(string path, string column, string value)
        {
            Class1.Update( path,  column,  value);
        }

        List<string> Interface1.Info()
        {
            return Class1.Info();
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryProject;

namespace ObjectWCF
{
    [ServiceContract]
    interface Interface
    {

        [OperationContract]
        void Insert(string name, double size, string path, string format, DateTime date);

        [OperationContract]
        void Delete(string par);

        [OperationContract]
        void newCol(string par);

        [OperationContract]
        void deleteCol(string par);

        [OperationContract]
        void Update(string path, string column, string value);

    }
}
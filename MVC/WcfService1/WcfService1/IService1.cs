using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IEnumerable<Person> GetPerson();
        [OperationContract]
        void insertPerson(Person p1);

        [OperationContract]
        void deletePerson(int id);


        [OperationContract]
        void updateperson(Person p1);
    }
}

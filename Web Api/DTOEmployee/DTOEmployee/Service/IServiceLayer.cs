using DTOEmployee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOEmployee.Service
{
  public  interface IServiceLayer
    {
        void delete(DtoDeleteEmp e);
        List<Employee> getEmployee();

        void insert(Employee e);


    }
}

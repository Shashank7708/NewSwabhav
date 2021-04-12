using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTOEmployee.Models;
namespace DTOEmployee.Service
{
    public interface IService
    {
        void delete(DeleteEmp e)
        List<DTOEMp> getEmployee()
    }
}
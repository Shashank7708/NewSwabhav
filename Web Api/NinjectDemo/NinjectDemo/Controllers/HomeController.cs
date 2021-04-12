using NinjectDemo.Business;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NinjectDemo.Controllers
{
    public class HomeController : ApiController
    {
        private readonly ICalculator _calculator;
        public HomeController(ICalculator calc)
        {
            Debug.Write("Hello");
            _calculator = calc;
        }
        public IHttpActionResult getSum(int num1,int num)
        {
            int val = _calculator.sum(num1, num);
            return Ok(val);
        }


    }
}

using System.Web.Http;
using SimpleWebApi2.Ninject.Business;

namespace SimpleWebApi2.Ninject.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ICaclulator _caclulator;
        public ValuesController(ICaclulator calculator)
        {
            _caclulator = calculator;
        }

        public int Get(int num1, int num2)
        {
            return _caclulator.Add(num1, num2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerse.Coffee.Domain.Exceptions
{
    public class SomethingWentWrong : Exception
    {
        public SomethingWentWrong(string message) 
            : base(message)
        { }
    }
}

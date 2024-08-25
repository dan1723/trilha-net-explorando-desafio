using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class ExcecaoPersonalizada : ApplicationException
    {
        public ExcecaoPersonalizada(string message) : base(message)
        {
            
        }
    }
}
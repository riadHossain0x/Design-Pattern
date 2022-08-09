using BusinessInterface;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validations
{
    public class ProgrammerValidation : IValidation<IEmployee>
    {
        public void Validate(IEmployee obj)
        {
            if (obj == null)
                throw new InvalidOperationException();
        }
    }
}

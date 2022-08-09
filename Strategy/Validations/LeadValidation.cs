using BusinessInterface;
using BusinessLayer;

namespace Validations
{
    public class LeadValidation : IValidation<IEmployee>
    {
        public void Validate(IEmployee obj)
        {
            if (obj.Name == null)
                throw new InvalidOperationException();
            if (obj.Designation == null)
                throw new InvalidOperationException();
        }
    }
}
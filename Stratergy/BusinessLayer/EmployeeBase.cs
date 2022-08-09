using BusinessInterface;

namespace BusinessLayer
{
    public class EmployeeBase : IEmployee
    {
        public string Name { get; set; }
        public string Designation { get; set; }

        private IValidation<IEmployee> _validation;

        public EmployeeBase()
        {

        }

        public EmployeeBase(IValidation<IEmployee> obj)
        {
            _validation = obj;
        }

        public virtual void Validate()
        {
            _validation.Validate(this);
        }
    }

    public class Lead : EmployeeBase
    {
        public Lead(IValidation<IEmployee> obj) : base(obj)
        {
        }
    }

    public class Programmer : EmployeeBase
    {
        public Programmer(IValidation<IEmployee> obj) : base(obj)
        {
        }
    }
}
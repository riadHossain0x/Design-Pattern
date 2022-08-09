using BusinessInterface;
using BusinessLayer;
using Unity;
using Unity.Injection;
using Validations;

namespace FactoryCustomer
{
    public static class Factory
    {
        private static IUnityContainer _unity;
        public static IEmployee Create(string type)
        {
            _unity = new UnityContainer();
            _unity.RegisterType<IEmployee, Lead>("Lead", new InjectionConstructor(new LeadValidation()));
            _unity.RegisterType<IEmployee, Programmer>("Programmer", new InjectionConstructor(new ProgrammerValidation()));

            return _unity.Resolve<IEmployee>(type);
        }
    }
}
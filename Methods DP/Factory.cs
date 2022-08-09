using Factory_DP;

namespace Factory_DP
{
    public class Factory
    {
        private Lazy<Dictionary<string, EmplyeeBase>> _EmployeeType;

        public EmplyeeBase Create(string type)
        {
            _EmployeeType = new Lazy<Dictionary<string, EmplyeeBase>>(() => LoadData());
            return _EmployeeType.Value[type];
        }

        public Dictionary<string, EmplyeeBase> LoadData() =>
            new Dictionary<string, EmplyeeBase>
            {
                { "Lead", new Lead() },
                { "Programmer", new Programmer() }
            };
    }
}

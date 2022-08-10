namespace BusinessInterface
{
    public interface IEmployee
    {
        string Name { get; set; }
        string Designation { get; set; }
        void Validate();
    }

    public interface IValidation<T>
    {
        void Validate(T obj);
    }
}
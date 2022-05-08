namespace iocContainers.Repository
{
    public class NameService : INameService
    {
        public string Execute(string Name, string Surname)
        {
            return Name.Substring(0, 1).ToString().ToUpper() +
                Name.Substring(1) + Surname.ToUpper();
        }
    }
}
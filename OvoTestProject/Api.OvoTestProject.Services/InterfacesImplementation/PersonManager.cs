using Api.OvoTestProject.Services.Interfaces;

namespace Api.OvoTestProject.Services.InterfacesImplementation
{
    public class PersonManager : IPersonManager
    {
        public string ToUppper(string value)
        {
                return !string.IsNullOrWhiteSpace(value)
                ? value.ToUpper()
                : value;
        }
    }
}

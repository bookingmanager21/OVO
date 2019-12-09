using Api.OvoTestProject.Services.Interfaces;

namespace Api.OvoTestProject
{
    public class ApplicationServiceLocator : IApplicationServiceLocator
    {
        public ApplicationServiceLocator(IPersonManager stringManager)
        {
            StringManager = stringManager;
        }

        public IPersonManager StringManager { get; }
    }
}

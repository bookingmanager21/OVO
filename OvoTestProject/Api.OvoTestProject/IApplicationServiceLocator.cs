using Api.OvoTestProject.Services.Interfaces;

namespace Api.OvoTestProject
{
    public interface IApplicationServiceLocator
    {
        public IPersonManager StringManager { get; }
    }
}

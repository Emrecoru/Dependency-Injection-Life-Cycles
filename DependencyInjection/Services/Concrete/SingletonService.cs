using DependencyInjection.Services.Abstract;

namespace DependencyInjection.Services.Concrete
{
    public class SingletonService : ISingletonService
    {
        private string _guidId;

        public SingletonService()
        {
            _guidId = Guid.NewGuid().ToString();
        }
        public string GuidId => _guidId;
    }
}

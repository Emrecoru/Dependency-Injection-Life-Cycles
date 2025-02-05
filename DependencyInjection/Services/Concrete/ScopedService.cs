using DependencyInjection.Services.Abstract;

namespace DependencyInjection.Services.Concrete
{
    public class ScopedService : IScopedService
    {
        private string _guidId { get; set; }

        public ScopedService()
        {
            _guidId = Guid.NewGuid().ToString();
        }
        public string GuidId => _guidId;
    }
}

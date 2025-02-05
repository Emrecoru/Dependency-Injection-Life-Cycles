using DependencyInjection.Services.Abstract;

namespace DependencyInjection.Services.Concrete
{
    public class TransientService : ITransientService
    {
        private string _guidId { get; set; }

        public TransientService()
        {
            _guidId = Guid.NewGuid().ToString();
        }
        public string GuidId => _guidId;
    }
}

using Core.Infrastructure.Interfaces;
using Core.View;

namespace Core.Infrastructure.Controllers
{
    public abstract class BaseController
    {
        public IView View { get; set; }
        public ICommand CommandModel { get; set; }
    }
}
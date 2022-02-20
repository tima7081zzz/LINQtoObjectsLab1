using Core.Infrastructure.Logic;
using Core.View;

namespace Core.Infrastructure.Controllers
{
    public class ControllerBuilder
    {
        private Controller _controller;

        public ControllerBuilder()
        {
            _controller = new Controller();
        }

        public ControllerBuilder SetDefaultData()
        {
            _controller.CommandModel = new Command();
            _controller.CommandModel.GenerateDefaultData();
            return this;
        }

        public ControllerBuilder SetView(IView view)
        {
            _controller.View = view;
            return this;
        }

        public Controller Build() => _controller;
    }
}
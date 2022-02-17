using Core.Models;
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

        public ControllerBuilder SetCommandModel(ICommandModel model)
        {
            _controller.CommandModel = model;
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
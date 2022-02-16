using Core.Infrastructure;
using Core.Infrastructure.Interfaces;

namespace Core.Models
{
    public interface ICommandModel
    {
        CommandModelWrapper Execute(CommandModelWrapper model);
    }
    public class CommandModel : ICommandModel
    {
        private readonly ICommand command;

        public CommandModel(ICommand command)
        {
            this.command = command;
        }

        public CommandModelWrapper Execute(CommandModelWrapper model) => command.Result(model);
    }
}
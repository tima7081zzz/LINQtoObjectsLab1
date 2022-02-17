using System.Linq;
using System.Text;
using Core.Models;
using Core.View;

namespace Core.Infrastructure.Controllers
{
    public abstract class BaseController
    {
        public virtual IView View { get; set; }
        public virtual ICommandModel CommandModel { get; set; }
        public abstract void Click();
    }

    public class Controller : BaseController
    {
        public override void Click()
        {
            var model = new CommandModelWrapper
            {
                Students = View.Students,
                Professors = View.Professors,
                Work = View.Works,
            };

            View.Result = CommandModelWrapperStringConvert(CommandModel.Execute(model));
        }

        private static string CommandModelWrapperStringConvert(CommandModelWrapper model)
        {
            var result = new StringBuilder();

            model.Professors?.ToList().ForEach(x => result.Append(x));
            model.Students?.ToList().ForEach(x => result.Append(x));
            model.Work?.ToList().ForEach(x => result.Append(x));

            return result.ToString();
        }
    }
}
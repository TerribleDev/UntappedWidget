using Nancy;
using UntappedWidgetGenerator.Interface;

namespace UntappedWidgetGenerator.Web
{
    public class IndexModule : NancyModule
    {
        public IndexModule(IUntappedRepository repository )
        {
            Get["/"] = x => {
               return View["Views/Index/Index.cshtml", "tparnell"];
                };
            Get["/{username}/browse"] = x => View["Views/Index/Index.cshtml", (string)x.username];
            Get["/{username}/html"] = parameters =>
            {
                var info = repository.Get(parameters.username);
                return View["Profile", info];
            };
            Get["/{username}"] = parameters => Response.AsJson(repository.Get((string)parameters.username));
        }
    }
}

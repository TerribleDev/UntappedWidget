using System.Collections.Generic;
using UntappedWidgetGenerator.Model;

namespace UntappedWidgetGenerator.Web
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = x => { return View["Views/Index/Index.cshtml", "tparnell"]; };
            Get["/{username}/browse"] = x => { return View["Views/Index/Index.cshtml", (string)x.username]; };
            Get["/{username}/html"] = parameters =>
            {
                var info = new UntappedRepository().Get(parameters.username);
                return View["Profile", info];
            };
            Get["/{username}"] = parameters => Response.AsJson(new UntappedRepository().Get((string)parameters.username));
        }
    }
}

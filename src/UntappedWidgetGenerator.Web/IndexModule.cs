using System.Collections.Generic;
using UntappedWidgetGenerator.Model;

namespace UntappedWidgetGenerator.Web
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/{username}"] = parameters =>
            {
                return View["Views/Index/Index.cshtml", (string)parameters.username];
            };
            Post["/{username}"] = parameters =>
            {
                var info = new UntappedRepository().Get(parameters.username);
                return View["Profile", info];
            };
        }
    }
}
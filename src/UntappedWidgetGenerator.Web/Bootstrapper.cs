using Nancy.Bootstrapper;
using Nancy.Routing;
using Nancy.TinyIoc;
using UntappedWidgetGenerator.Interface;

namespace UntappedWidgetGenerator.Web
{
    using Nancy;

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);
            container.Register<IUntappedRepository, UntappedRepository>();
        }
    }
}
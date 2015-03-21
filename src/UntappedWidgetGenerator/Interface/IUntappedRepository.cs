using UntappedWidgetGenerator.Model;

namespace UntappedWidgetGenerator.Interface
{
    public interface IUntappedRepository
    {
        WidgetViewModel Get(string username);
    }
}

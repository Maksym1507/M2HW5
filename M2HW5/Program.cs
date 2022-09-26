using Autofac;
using M2HW5.Configs;

namespace M2HW5
{
    class Program
    {
        private static void Main()
        {
            var config = new Config();
            var container = config.RegisterTypes();
            var start = container.Resolve<Starter>();
            start.Run();
        }
    }
}

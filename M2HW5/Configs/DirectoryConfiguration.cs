using M2HW5.Models;

namespace M2HW5.Configs
{
    public class DirectoryConfiguration
    {
        public DirectoryConfiguration()
        {
            Directory = new DirectoryName();
        }

        public DirectoryName Directory { get; }
    }
}

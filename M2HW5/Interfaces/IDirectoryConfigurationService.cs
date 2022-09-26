namespace M2HW5.Interfaces
{
    public interface IDirectoryConfigurationService
    {
        public void SerializeDirectory(string filePath);

        public string DeserializeDirectory(string filePath);
    }
}

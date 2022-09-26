using Autofac;
using M2HW5.Interfaces;
using M2HW5.Models;
using M2HW5.Services;

namespace M2HW5.Configs
{
    public class Config
    {
        public Config()
        {
            Builder = new ContainerBuilder();
        }

        private ContainerBuilder Builder { get; set; }

        public IContainer RegisterTypes()
        {
            Builder.RegisterType<NotificationService>().As<INotificationService>();
            Builder.RegisterType<Logger>().As<ILogger>();
            Builder.RegisterType<FileService>().As<IFileService>();
            Builder.RegisterType<Actions>().As<IActions>();
            Builder.RegisterType<DirectoryConfigurationService>().As<IDirectoryConfigurationService>();
            Builder.RegisterType<Starter>();
            return Builder.Build();
        }
    }
}

using Autofac;
using MoneyBook.UI.Data;
using MoneyBook.UI.ViewModel;

namespace MoneyBook.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<InstitutionDataService>().As<IInstitutionDataService>();

            return builder.Build();
        }
    }
}



using Autofac;
using MathGame.Data;
using MathGame.Players;
using MathGame.Services;

namespace MathGame.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType <MathGameDbContext>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainWindowViewModel>().AsSelf();
            builder.RegisterType<PlayerListView>().AsSelf();
            builder.RegisterType<PlayerListViewModel>().AsSelf();
            builder.RegisterType<PlayerRepository>().As<IPlayerRepository>();

            return builder.Build();
        }
    }
}

using DataAccess;
using DataAccess.Repository.CRepository;
using DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace SalesWpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider? serviceProvider;

        public App()
        {
            //Configure Dependency Injection
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();

            services.AddSingleton<MainWindow>();
            services.AddSingleton<WindowHome>();
            services.AddSingleton<WindowLogin>();
            services.AddSingleton<WindowMembers>();
            services.AddSingleton<WindowOrders>();
            services.AddSingleton<WindowOrderDetails>();
            services.AddSingleton<WindowProducts>();
        }

        private void OnStartup(object sender, EventArgs e)
        {
            var mainWindow = serviceProvider?.GetService<MainWindow>();
            mainWindow?.Show();
        }
    }

}

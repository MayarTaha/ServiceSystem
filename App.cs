   using Microsoft.Extensions.DependencyInjection;
   using Microsoft.EntityFrameworkCore;
   using ServiveceSystem.Models;

   public partial class App : Application
   {
       public static IServiceProvider ServiceProvider { get; private set; }

       protected override void OnStartup(StartupEventArgs e)
       {
           var services = new ServiceCollection();

           services.AddDbContext<AppDBContext>(options =>
               options.UseSqlServer("Server=.;Database=ServiceSystem;Trusted_Connection=True;Trust server certificate=true"));

           // Register your services
           services.AddTransient<InvoiceHeaderService>();

           ServiceProvider = services.BuildServiceProvider();

           base.OnStartup(e);
       }
   }
   
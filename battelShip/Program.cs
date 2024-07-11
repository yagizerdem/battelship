using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using static Supabase.Realtime.PostgresChanges.PostgresChangesOptions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace battelShip
{
    internal static class Program 
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            ApplicationConfiguration.Initialize(); // initlze app config file 

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            
            IDatabase db = ServiceProvider.GetService<IDatabase>()!;
            await db.Initilize();


            await db.supabase.From<Room>().On(ListenType.Updates, async (sender, change) =>
            {
                Debug.WriteLine(change.Payload.Data);
                Room updated = change.Model<Room>();


                Supabase.Gotrue.User session = db.GetSession();
                string? userid = session.Id;

                if(updated?.player1id == userid)
                {
                    Game game = new Game();
                    game.ShowDialog();
                }

            });


            Application.Run(ServiceProvider.GetRequiredService<Home>()); // run app with dependency injection container
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddSingleton<IDatabase, Database>();
                    services.AddTransient<Home>();
                });
        }
    }
}
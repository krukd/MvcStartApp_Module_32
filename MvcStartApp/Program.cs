namespace MvcStartApp
{
    public class Program
    {
            /// <summary>
            ///  Точка входа - метод Main
            /// </summary>
            public static void Main(string[] args)
            {
                CreateHostBuilder(args).Build().Run();
            }

            /// <summary>
            /// Статический метод, создающий и настраивающий IHostBuilder -
            /// объект, который в свою очередь создает хост для развертывания нашего приложения
            /// </summary>

            public static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args)
                    .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });


            /*var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();*/
        
    }
}
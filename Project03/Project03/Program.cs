namespace Project03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            app.UseStaticFiles();
            //app.MapGet("/", () => "Hello World!");
            app.MapControllerRoute(name: "Default",
                                   pattern: "{Controller}/{action}/{Id?}",
                                   defaults: new { controller ="Home" , action = "Index" },
                                   constraints:new {Id= @"\d{2}"});
            
            app.Run();
        }
    }
}

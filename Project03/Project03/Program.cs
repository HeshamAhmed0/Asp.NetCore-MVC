namespace Project03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.MapControllerRoute(name: "Default",
                                   pattern: "{Controller}/{action}/{Id?}",
                                   defaults: new { controller ="HomeController" , action = "ReturnResul" },
                                   constraints:new {Id= @"\d{2}"});

            app.Run();
        }
    }
}

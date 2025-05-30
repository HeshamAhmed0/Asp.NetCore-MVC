namespace P
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

            app.MapControllerRoute(name: "default",
                pattern:"/{Controller=Home}/{action=Index}");

            app.Run();
        }
    }
}

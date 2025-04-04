namespace project02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            #region Configure Servies
             builder.Services.AddControllersWithViews();
            #endregion
                   
            var app = builder.Build();


            #region SEGMENTS

            #region Static SEGMENTS
            app.MapGet("/", () => "Hello World!");

            #endregion
            #region Variable SEGMENTS
            app.MapGet("/{name}", async context =>
            {
                var Name = context.GetRouteValue("name");
                await context.Response.WriteAsync($"Hello {Name}");
            });

            #endregion

            #endregion
            app.Run();
        }
    }
}

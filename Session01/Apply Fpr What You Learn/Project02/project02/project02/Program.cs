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
            app.MapGet("/{name}", async Hesham =>
            {
                var Name = Hesham.GetRouteValue("name");
             await  Hesham.Response.WriteAsync($"Hello {Name}");
            });

            #endregion

            #endregion
            app.Run();
        }
    }
}

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

            #region Mixed Segment
            app.MapGet("/X{name}", async Hesam =>
            {
                await Hesam.Response.WriteAsync($"Hello {Hesam.Request.RouteValues["name"]}");
            });
            #endregion

            #region Controller Routing
            app.MapControllerRoute(name: "Default",
                                   pattern: "/{Controller}/{action}/{Id?}");
            // ??? ???? ????? ????? ????????? ??? ??? 
            //ID 
            // ?????? ???? optional       ???? ?????? ????? ?? 
            #endregion

            #endregion
            app.Run();
        }
    }
}

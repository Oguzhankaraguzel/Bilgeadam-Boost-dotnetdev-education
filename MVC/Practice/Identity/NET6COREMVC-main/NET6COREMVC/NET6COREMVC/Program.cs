var builder = WebApplication.CreateBuilder(args);
//builder -> inşaat
//builder.Services.AddControllers();
builder.Services.AddControllersWithViews();



var app = builder.Build();

//client "/"
//localhost:portNo
//localhost:portNo/
app.MapGet("/ilkBilgi", () => "Hello World!");
app.MapGet("/hakkimda", () => "Fatih Kaan Açıkgöz");
app.MapGet("/baslik1", () => "<h1>Başlık 1</h1>");
//Context => DbContext
//HttpContext
app.MapGet("/textHTMLkullanimi", async (context) =>
{
    //HTTP Header'ın içerisine gömülüyor!
    //context.Response.ContentType = "text/html;charset=utf-8";
    context.Response.ContentType = "text/html;charset=utf-8";
    context.Response.Headers["content-type"] = "text/html;charset=utf-8";

    context.Response.Headers["isim"] = "FKA";
    context.Response.Headers["htmlKodu"] = "<h1>Baslik 1</h1>";
    context.Response.Headers["date"] = "zaman maman yok";

    await context.Response.Body.WriteAsync(new byte[3] { 65, 66, 67 });
    await context.Response.WriteAsync("<h1>Başlık 1</h1>");
});


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.UseStaticFiles();

app.Run();

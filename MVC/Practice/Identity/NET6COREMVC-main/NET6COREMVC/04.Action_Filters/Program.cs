using _04.Action_Filters.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllers(mvcOptions =>
{
    mvcOptions.Filters.Add<CustomActionFilter>(-3);
});

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

app.Use(async (baglam, next) =>
{
    await next();
    if (baglam.Response.StatusCode == 404)
    {
        baglam.Request.Path = "/NotFound";
        await next();
    }
});

app.UseRouting();
app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Ornek}/{action=Index}/{id?}");

app.Run();

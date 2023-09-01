var builder = WebApplication.CreateBuilder(args);
var benimPolitika = "Benim kaynak paylasimi politikam";

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddCors(options =>
{
	options.AddPolicy(benimPolitika,
					  politika =>
					  {
						  politika.WithOrigins("https://localhost")
						  .AllowAnyHeader()
						   .AllowAnyMethod()
						   .AllowAnyOrigin();
					  });
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
        baglam.Request.Path = "/Error/Bulunamadi";
        await next();
    }
});

app.UseRouting();
app.UseCors(benimPolitika);
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

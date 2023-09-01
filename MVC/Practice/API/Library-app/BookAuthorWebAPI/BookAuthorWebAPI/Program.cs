var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDistributedMemoryCache(); // �rnek olarak, bellek tabanl� bir da��t�lm�� �nbellek kullan�yoruz
builder.Services.AddSession(options =>
{
    options.Cookie.HttpOnly = true; // Sadece HTTP �zerinden eri�ilebilir
��� options.Cookie.IsEssential = true; // Oturum bilgileri �nemli oldu�u i�in gerekli
});


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
��� // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
��� app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();

app.UseAuthorization();





app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
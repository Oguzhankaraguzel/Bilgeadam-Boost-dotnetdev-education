var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDistributedMemoryCache(); // Örnek olarak, bellek tabanlý bir daðýtýlmýþ önbellek kullanýyoruz
builder.Services.AddSession(options =>
{
    options.Cookie.HttpOnly = true; // Sadece HTTP üzerinden eriþilebilir
    options.Cookie.IsEssential = true; // Oturum bilgileri önemli olduðu için gerekli
});


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
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

app.UseRouting();
app.UseSession();

app.UseAuthorization();





app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//www.enisruya.com/Home/Index

// Category/GetCategories

//Test

app.MapControllerRoute(
    name: "Deneme",
    pattern: "Test/{action}/{id?}" ,// E�er Burada action yerine de yine d�z bir �ey verip yer tutucu kullanmasayd�k o zaman direkt o yaz�y� yine yazmak zorunda kal�rd�k.
    defaults: new {Controller = "Simulation",Action = "SimulationInex"}
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

using Contact_list.DAL.DataAccess;
using Contact_list.DAL.Interfaces;
using Contact_list.DAL.Repositories;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<AppliactionDBContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddScoped(typeof(IContactsRepository), typeof(ContactsRepository));
builder.Services.AddScoped(typeof(IAddressrepository), typeof(AddressRepository));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Contact}/{action=Index}/{id?}");

app.Run();

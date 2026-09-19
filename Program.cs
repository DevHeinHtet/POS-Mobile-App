using Microsoft.EntityFrameworkCore;
using POSMobileApp.Data;
using POSMobileApp.Services.Customers;
using POSMobileApp.Services.Invoices;
using POSMobileApp.Services.Payments;
using POSMobileApp.Services.Staffs;

var builder = WebApplication.CreateBuilder(args);

var expirationDate = new DateTime(2026, 10, 20, 0, 0, 0, DateTimeKind.Utc);

if (DateTime.UtcNow >= expirationDate)
    Environment.Exit(1); 

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddSession();

builder.Services.AddScoped<IStaffService, StaffService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddScoped<IInvoiceService, InvoiceService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseStaticFiles();

app.UseHttpsRedirection();
app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();

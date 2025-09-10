using SampleAppPractice.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


builder.Services.AddSingleton(provider => new SmtpSettings
{
	Host = "smtp.example.com",
	Port = 25
});
builder.Services.AddSingleton<IMessageFactory,MessageFactory>();
builder.Services.AddSingleton<ISmtpClient,SmtpClient>();
builder.Services.AddSingleton<IMessanger,Messanger>();

var app = builder.Build();

if(!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapDefaultControllerRoute();

app.Run();

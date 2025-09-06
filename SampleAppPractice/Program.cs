var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<SampleAppPractice.Models.MessageFactory>();
builder.Services.AddSingleton(provider => new SampleAppPractice.Models.SmtpSettings
{
	Host = "smtp.example.com",
	Port = 25
});
builder.Services.AddSingleton<SampleAppPractice.Models.SmtpClient>();
builder.Services.AddSingleton<SampleAppPractice.Models.Messanger>();
var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();

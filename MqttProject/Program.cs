using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MqttProject.Data;
using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(); // ***********************************************
builder.Services.AddDbContext<contactData>( options => 
 options.UseSqlServer(builder.Configuration.GetConnectionString("AppSettingsDbContext"))
 ); 

builder.Services.AddCors((setup) =>
{
    setup.AddPolicy("default", (options) =>
    {
        options.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
    });
});



var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(b=>b.WithOrigins("http://localhost:4200").AllowAnyHeader()); //********************

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


MqttClient mqttClient = new MqttClient("broker.hivemq.com");
string clientId = Guid.NewGuid().ToString();

mqttClient.Connect(clientId);
Console.WriteLine("Abone Olundu: test/deneme");

Console.WriteLine("Mesajý girin: ");
string message = Console.ReadLine();
string Topic = "test/deneme";
mqttClient.Publish(Topic, Encoding.UTF8.GetBytes(message), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);



app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials()); // allow credentials

using Avancerd_.NET_Labb3.Data;

using Avancerd_.NET_Labb3.Services.Interfaces;
using Avancerd_.NET_Labb3.Services.Repositories;
using Labb3_Models_;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text.Json.Serialization;

namespace Avancerd_.NET_Labb3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddScoped<Labb3Interface<Person>, PersonRepo>();
            builder.Services.AddScoped<Labb3Interface<Hobby>, HobbyRepo>();
            builder.Services.AddScoped<Labb3Interface<Link>, LinkRepo>();

            builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

using RealEstate.Domain.Entities;
using RealEstate.Presistence;
using System.Security.Cryptography.Xml;

namespace RealEstate.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new DataContext();

            var cities = db.Cities.ToList();

            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}

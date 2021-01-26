using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Net.Mime;
using Province.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data;
using Province.Data;
namespace Province.Data{
public static class SeedData{
// public static void Initialize(IApplicationBuilder app) { 
//     using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope()) {
//       var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
//       context.Database.EnsureCreated();

//       // Look for any Cities.
//       if (context.Cities.Any()) {
//           return;   // DB has already been seeded
//       }

//       var Cities = GetCities().ToArray();
//       context.Cities.AddRange(Cities);
//       context.SaveChanges();

//       var Province = GetProvince(context).ToArray();
//       context.Province.AddRange(Province);
//       context.SaveChanges();
//     }
//   }

    public static void Seed(this ModelBuilder modelBuilder){
        modelBuilder.Entity<Provinces>().HasData(
            GetProvince()
        );
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }


    public static List<City> GetCities() {
        List<City> Cities = new List<City>() {
            new City() {
                CityId=1,
                CityName="Vancouver",
                Population=150,
                ProvinceName ="BC",
                
            },
            new City() {
                CityId=2,
                CityName="Burnaby",
                Population=120,
                ProvinceName ="BC",
            },
            new City() {
                CityId=3,
                CityName="Edmonton",
                Population=130,
                ProvinceName ="AB",
            },

        };

        return Cities;
    }

    public static List<Provinces> GetProvince() {
        List<Provinces> Province = new List<Provinces>() {
            new Provinces {
                ProvinceCode = "BC",
                ProvinceName = "British Columbia",
            
            },
            new Provinces {
                ProvinceCode = "AB",
                ProvinceName = "Alberta",
            },

        };

        return Province;
    }
}
}
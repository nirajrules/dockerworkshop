using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WeatherWeb.Models
{
    public class WeatherWebContext : DbContext
    {
        public WeatherWebContext (DbContextOptions<WeatherWebContext> options)
            : base(options)
        {
        }

        public DbSet<WeatherWeb.Models.WeatherData> WeatherData { get; set; }
    }
}

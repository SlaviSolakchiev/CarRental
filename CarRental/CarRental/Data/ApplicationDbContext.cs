using CarRental.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<ReservationInfo> ReservationInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ReservationInfo>()
                .HasOne(ri => ri.PickUpLocation)
                .WithMany(pl => pl.ReservationInfosForPickUpLocations)
                .OnDelete(DeleteBehavior.NoAction);


            builder.Entity<ReservationInfo>()
               .HasOne(ri => ri.ReturnLocation)
               .WithMany(pl => pl.ReservationInfosForReturnLocations)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<ReservationInfo>()
             .HasOne(ri => ri.User)
             .WithOne(au => au.ReservationInfo)
              .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(builder);

        }
    }
}

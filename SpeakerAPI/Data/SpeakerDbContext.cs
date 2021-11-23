using System;
using Microsoft.EntityFrameworkCore;
using SpeakerLibrary;

namespace SpeakerAPI.Data
{
    public class SpeakerDbContext : DbContext
    {
        public DbSet<Speaker> Students { get; set; }

        public SpeakerDbContext(DbContextOptions<SpeakerDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Speaker>().HasData(
              new
              {
                  SpeakerId = Guid.NewGuid().ToString(),
                  FirstName = "Tom",
                  LastName = "Day",
                  Email = "tom@day.com",
                  Mobile = "6041111111",
                  Specialization = "Love",
                  City = "Burnaby",
                  Province = "BC",
                  Employer = "Tinder"
              }, new
              {
                  SpeakerId = Guid.NewGuid().ToString(),
                  FirstName = "Ann",
                  LastName = "Fox",
                  Email = "ann@fox.com",
                  Mobile ="6042222222",
                  Specialization ="Hunting",
                  City ="Langley",
                  Province ="BC",
                  Employer ="Hunter"
              }, new
              {
                  SpeakerId = Guid.NewGuid().ToString(),
                  FirstName = "Art",
                  LastName = "Ash",
                  Email = "art@ash.com",
                  Mobile = "6043333333",
                  Specialization = "Art",
                  City = "Vancouver",
                  Province = "BC",
                  Employer = "Art Gallery"
              }, new
              {
                  SpeakerId = Guid.NewGuid().ToString(),
                  FirstName = "Mia",
                  LastName = "Hay",
                  Email = "mia@hay.com",
                  Mobile = "6044444444",
                  Specialization = "Farmer",
                  City = "Coquitlam",
                  Province = "BC",
                  Employer = "Hayers"
              }
            );
        }
    }

}

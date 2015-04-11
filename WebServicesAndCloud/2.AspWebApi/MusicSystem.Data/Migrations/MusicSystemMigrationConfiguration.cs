namespace MusicSystem.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Models;

    public class MusicSystemMigrationConfiguration : DbMigrationsConfiguration<MusicSystemEntities>
    {
        public MusicSystemMigrationConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MusicSystemEntities context)
        {
            if (!context.Albums.Any())
            {
                var country = new Country
                {
                    Name = "Bulgaria"
                };
                context.Countries.Add(country);

                var artist = new Artist
                {
                    Name = "Peter Petrov",
                    DateOfBirth = new DateTime(2000, 1, 1),
                    Country = country
                };
                context.Artists.Add(artist);

                var producer = new Producer
                {
                    Name = "Todor Todorov"
                };
                context.Producers.Add(producer);

                var album = new Album
                {
                    Year = 2015,
                    Title = "The best hits",
                    Songs = new HashSet<Song>
                {
                    new Song
                    {
                        Artist = artist,
                        Genre = Genre.Jazz,
                        Title = "La-la",
                        Year = 2015
                    },
                    new Song
                    {
                        Artist = artist,
                        Genre = Genre.Pop,
                        Title = "Tra-la-la",
                        Year = 2015
                    }
                },
                    Producer = producer,
                    Artists = new HashSet<Artist>
                    {
                        artist
                    }
                };
                context.Albums.Add(album);
                context.SaveChanges();
            }
        }
    }
}

using Labb3_Models_;
using Microsoft.EntityFrameworkCore;

namespace Avancerd_.NET_Labb3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
     

            //Seed data.... Hobbies
            modelBuilder.Entity<Hobby>().HasData(new Hobby
            {
                HobbyID = 1,
                HobbyTitle = "Skiing",
                HobbyDescription = "Skiing down the mountains... ",
               
            });

            modelBuilder.Entity<Hobby>().HasData(new Hobby
            {
                HobbyID = 2,
                HobbyTitle = "Knitting",
                HobbyDescription = "Knitting shirts, mittens and hats ",
             
            });

            modelBuilder.Entity<Hobby>().HasData(new Hobby
            {
                HobbyID = 3,
                HobbyTitle = "Surfing",
                HobbyDescription = "Surfing the waves like a real proffesional ",
        

            });

            modelBuilder.Entity<Hobby>().HasData(new Hobby
            {
                HobbyID = 4,
                HobbyTitle = "Hacking",
                HobbyDescription = "Hacking computers since 1996 ",
        
            });

            modelBuilder.Entity<Hobby>().HasData(new Hobby
            {
                HobbyID = 5,
                HobbyTitle = "Swimming",
                HobbyDescription = "Swimming like Phelps since 1996",
      
            });

            modelBuilder.Entity<Hobby>().HasData(new Hobby
            {
                HobbyID = 6,
                HobbyTitle = "Boule",
                HobbyDescription = "Throwing larger balls at smaller balls, really fun",

            });

            modelBuilder.Entity<Hobby>().HasData(new Hobby
            {
                HobbyID = 7,
                HobbyTitle = "Gaming",
                HobbyDescription = "Gaming all kinds of games, FPS, MMORPG and RTS games",

            });

            modelBuilder.Entity<Hobby>().HasData(new Hobby
            {
                HobbyID = 8,
                HobbyTitle = "Hockey",
                HobbyDescription = "Skating and punching people since 1996"
            });



            //Seed data.... Links
            //Hobby 1
            modelBuilder.Entity<Link>().HasData(new Link
            {
               LinkID = 1,
               URL = "https://en.wikipedia.org/wiki/Skiing",

            });
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkID = 2,
                URL = "https://visitsweden.com/what-to-do/nature-outdoors/winter-activities/skiing-sweden/",

            });
            //Hobby 2
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkID = 3,
                URL = "https://en.wikipedia.org/wiki/Knitting",

            });
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkID = 4,
                URL = "https://sheepandstitch.com/how-to-knit/",

            });
            //Hobby 3
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkID = 5,
                URL = "https://sv.wikipedia.org/wiki/Surfing",

            });
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkID = 6,
                URL = "https://www.kilroy.se/reseblogg/8-fantastiska-surfdestinationer-over-hela-varlden",

            });
            //Hobby 4
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkID = 7,
                URL = "https://www.ibm.com/topics/cyber-hacking",
 
            });
            //Hobby 5
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkID = 8,
                URL = "https://en.wikipedia.org/wiki/Swimming_(sport)",
   
            });
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkID = 9,
                URL = "https://www.britannica.com/sports/swimming-sport",
   
            });
            //Hobby 6
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkID = 10,
                URL = "https://sv.wikipedia.org/wiki/Boule",

            });
            //Hobby 7
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkID = 11,
                URL = "https://sv.wikipedia.org/wiki/Gamer",

            });
            //Hobby 8
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkID = 12,
                URL = "https://www.swehockey.se",

            });
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkID = 13,

                URL = "https://sv.wikipedia.org/wiki/Ishockey",
            });



            //Seed data....Persons
            modelBuilder.Entity<Person>().HasData(new Person
            {
                PersonID = 1,
                FirstName = "Ludwig",
                LastName = "Qlok",
                PhoneNumber = "070123456",     
                Hobbies = new List<Hobby> 
                {
                    
                } 
                
            });
            modelBuilder.Entity<Person>().HasData(new Person
            {
                PersonID = 2,
                FirstName = "Anas",
                LastName = "Qlok",
                PhoneNumber = "070765431",
            });
            modelBuilder.Entity<Person>().HasData(new Person
            {
                PersonID = 3,
                FirstName = "Reidar",
                LastName = "Qlok",
                PhoneNumber = "070098765",
            });
        }
    }
}
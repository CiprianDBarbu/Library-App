using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Threading;
using System.Web;

namespace DeputRapid.Models.MyDatabaseInitializer
{
    public class DbCtx : DbContext
    {
        public DbCtx() : base("DbConnectionString")
        {
            //set the initializer here
            Database.SetInitializer<DbCtx>(new Initp());

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ContactInfo> ContactsInfo { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Region> Regions { get; set; }
    }

    public class Initp : DropCreateDatabaseAlways<DbCtx>
    {
        //custom initializer
        protected override void Seed(DbCtx context)
        {
            BookType cover1 = new BookType { BookTypeId = 67, Name = "HardCover" };
            BookType cover2 = new BookType { BookTypeId = 68, Name = "Paperback" };

            Region region1 = new Region { RegionId = 1, Name = "Alba" };
            Region region2 = new Region { RegionId = 2, Name = "Arad" };
            Region region3 = new Region { RegionId = 3, Name = "Arges" };
            Region region4 = new Region { RegionId = 4, Name = "Bacau" };

            context.BookTypes.Add(cover1);
            context.BookTypes.Add(cover2);

            context.Regions.Add(region1);
            context.Regions.Add(region2);
            context.Regions.Add(region3);
            context.Regions.Add(region4);
            context.Regions.Add(new Region { RegionId = 5, Name = "Bihor" });
            context.Regions.Add(new Region { RegionId = 6, Name = "Bistrița-Năsăud" });
            context.Regions.Add(new Region { RegionId = 7, Name = "Botoșani" });
            context.Regions.Add(new Region { RegionId = 8, Name = "Brașov" });
            context.Regions.Add(new Region { RegionId = 9, Name = "Brăila" });
            context.Regions.Add(new Region { RegionId = 10, Name = "Buzău" });
            context.Regions.Add(new Region { RegionId = 11, Name = "Caraș-Severin" });
            context.Regions.Add(new Region { RegionId = 12, Name = "Cluj" });
            context.Regions.Add(new Region { RegionId = 13, Name = "Constanța" });
            context.Regions.Add(new Region { RegionId = 14, Name = "Covasna" });
            context.Regions.Add(new Region { RegionId = 15, Name = "Dâmbovița" });
            context.Regions.Add(new Region { RegionId = 16, Name = "Dolj" });
            context.Regions.Add(new Region { RegionId = 17, Name = "Galați" });
            context.Regions.Add(new Region { RegionId = 18, Name = "Gorj" });
            context.Regions.Add(new Region { RegionId = 19, Name = "Harghita" });
            context.Regions.Add(new Region { RegionId = 20, Name = "Hunedoara" });
            context.Regions.Add(new Region { RegionId = 21, Name = "Ialomița" });
            context.Regions.Add(new Region { RegionId = 22, Name = "Iași" });
            context.Regions.Add(new Region { RegionId = 23, Name = "Ilfov" });
            context.Regions.Add(new Region { RegionId = 24, Name = "Maramureș" });
            context.Regions.Add(new Region { RegionId = 25, Name = "Mehedinți" });
            context.Regions.Add(new Region { RegionId = 26, Name = "Mureș" });
            context.Regions.Add(new Region { RegionId = 27, Name = "Neamț" });
            context.Regions.Add(new Region { RegionId = 28, Name = "Olt" });
            context.Regions.Add(new Region { RegionId = 29, Name = "Prahova" });
            context.Regions.Add(new Region { RegionId = 30, Name = "Satu Mare" });
            context.Regions.Add(new Region { RegionId = 31, Name = "Sălaj" });
            context.Regions.Add(new Region { RegionId = 32, Name = "Sibiu" });
            context.Regions.Add(new Region { RegionId = 33, Name = "Suceava" });
            context.Regions.Add(new Region { RegionId = 34, Name = "Teleorman" });
            context.Regions.Add(new Region { RegionId = 35, Name = "Timiș" });
            context.Regions.Add(new Region { RegionId = 36, Name = "Tulcea" });
            context.Regions.Add(new Region { RegionId = 37, Name = "Vaslui" });
            context.Regions.Add(new Region { RegionId = 38, Name = "Vâlcea" });
            context.Regions.Add(new Region { RegionId = 39, Name = "Vrancea" });
            context.Regions.Add(new Region { RegionId = 40, Name = "București" });
            context.Regions.Add(new Region { RegionId = 41, Name = "București-Sector 1" });
            context.Regions.Add(new Region { RegionId = 42, Name = "București-Sector-2" });
            context.Regions.Add(new Region { RegionId = 43, Name = "București-Sector-3" });
            context.Regions.Add(new Region { RegionId = 44, Name = "București-Sector-4" });
            context.Regions.Add(new Region { RegionId = 45, Name = "București-Sector 5" });
            context.Regions.Add(new Region { RegionId = 46, Name = "București -Sector 6" });
            context.Regions.Add(new Region { RegionId = 51, Name = "Călărași" });
            context.Regions.Add(new Region { RegionId = 52, Name = "Giurgiu" });

            ContactInfo contact1 = new ContactInfo
            {
                PhoneNumber = "0712345678",
                BirthDay = "16",
                BirthMonth = "03",
                BirthYear = 1991,
                CNP = "2910316014007",
                GenderType = Gender.Female,
                Resident = false,
                RegionId = region1.RegionId
            };

            ContactInfo contact2 = new ContactInfo
            {
                PhoneNumber = "0713345878",
                BirthDay = "07",
                BirthMonth = "04",
                BirthYear = 2002,
                CNP = "6020407023976",
                GenderType = Gender.Female,
                Resident = false,
                RegionId = region2.RegionId
            };

            ContactInfo contact3 = new ContactInfo
            {
                PhoneNumber = "0711345678",
                BirthDay = "30",
                BirthMonth = "10",
                BirthYear = 2002,
                CNP = "5021030031736",
                GenderType = Gender.Male,
                Resident = false,
                RegionId = region3.RegionId
            };

            ContactInfo contact4 = new ContactInfo
            {
                PhoneNumber = "0712665679",
                BirthDay = "13",
                BirthMonth = "05",
                BirthYear = 1986,
                CNP = "2860513040701",
                GenderType = Gender.Female,
                Resident = false,
                RegionId = region4.RegionId
            };


            context.Books.Add(new Book
            {
                Title = "The Atomic Times",
                Author = "Michael Harris",
                Summary = "The Atomic bomb Times",
                Publisher = new Publisher { Name = "Harper Collins", ContactInfo = contact1 },
                BookType = cover1,
                Genres = new List<Genre> { new Genre { Name = "Horror" } }
            });
            context.Books.Add(new Book
            {
                Title = "In Defense of Elitism",
                Author = "Joel Stein",
                Publisher = new Publisher { Name = "Macmillan Publishers", ContactInfo = contact2 },
                BookType = cover1,
                Genres = new List<Genre> { new Genre { Name = "Humor" } }
            });
            context.Books.Add(new Book
            {
                Title = "The Catenbury Tales",
                Author = "Geoffrey Chaucer",
                Summary = "At the Tabard Inn, a tavern in Southwark, near London, the narrator joins a company of twenty-nine pilgrims." +
            " The pilgrims, like the narrator, are traveling to the shrine of the martyr Saint Thomas Becket in Canterbury." +
            " The narrator gives a descriptive account of twenty-seven of these pilgrims," +
            " including a Knight, Squire, Yeoman, Prioress, Monk, Friar, Merchant, Clerk, Man of Law, Franklin," +
            " Haberdasher, Carpenter, Weaver, Dyer, Tapestry-Weaver, Cook, Shipman, Physician, Wife, Parson, Plowman, Miller, Manciple," +
            " Reeve, Summoner, Pardoner, and Host. (He does not describe the Second Nun or the Nun’s Priest, although both characters appear later in the book.)" +
            " The Host, whose name, we find out in the Prologue to the Cook’s Tale, is Harry Bailey, suggests that the group ride together and entertain one another with stories." +
            " He decides that each pilgrim will tell two stories on the way to Canterbury and two on the way back." +
            " Whomever he judges to be the best storyteller will receive a meal at Bailey’s tavern, courtesy of the other pilgrims." +
            " The pilgrims draw lots and determine that the Knight will tell the first tale.",
                Publisher = new Publisher { Name = "Scholastic", ContactInfo = contact3 },
                BookType = cover2,
                Genres = new List<Genre>
            {
                new Genre{Name = "Satire"},
                new Genre{Name = "Fabilau"},
                new Genre{Name = "Allegory"},
                new Genre{Name = "Burlesque"}
            }
            });

            context.Books.Add(new Book 
            {
                Title = "Python Crash Course, 2nd Edition: A hands-On, Project-Based Introduction to Programming",
                Author = "Eric Matthers",
                Publisher = new Publisher { Name = "Schol", ContactInfo = contact4},
                BookType = cover2,
                Genres = new List<Genre> { new Genre { Name = "Programming"} }
            });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
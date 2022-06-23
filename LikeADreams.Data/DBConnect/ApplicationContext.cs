using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeADreams.Data.DBConnect
{
    public class ApplicationContext
    {
        public DbSet<BaseComment> BaseComment { get; set; }
        public DbSet<Categorie> Categorie { get; set; }
        public DbSet<Check> Check { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Prechek> Prechek { get; set; }
        public DbSet<RegistrationAddress> RegistrationAddress { get; set; }
        public DbSet<Revenue> Revenue { get; set; }
        public DbSet<TypePersone> TypePersone { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Admin>().HasData(        Пример предворительного заполнения таблици перед первой миграцией.
            //new Admin()
            //{
            //    Id = 1,
            //    Name = "Admin",
            //    LastName = "Admin",
            //    Gender = Gender.Male,
            //    BirthDay = new DateTime(2000, 01, 01),
            //    Email = "Admin@mail.ru",
            //    Password = "1000:WvGHoK1WF2vO/ZkCz8FcmEdWsULri96e:oYQNDwkRfTN2Sm1fY56gS/5esvc=",
            //    Role = Role.Admin,
            //    IsDeleted = false,
            //}
            //);

        }
    }
}

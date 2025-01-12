using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using My_Portfolio.DAL.Entities;

namespace My_Portfolio.DAL.Context
{
    //Bağlantı sql adresi ve kullanılan metodlar. 
    public class My_PortfolioContex : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=IŞ\\SQLEXPRESS;initial Catalog=MyPortfolioDb;integrated Security=true; TrustServerCertificate=True;");
        }
        //TrustServerCertificate:update-database yaparken -> sertifika hatasını önler.


        //Entityleri Sql'e yansıtma. 
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios  { get; set; }
        public DbSet<Skill> Skills  { get; set; }
        public DbSet<SocialMedia> SocialMedias  { get; set; }
        public DbSet<Testimonial> Testimonials   { get; set; }



    }
}

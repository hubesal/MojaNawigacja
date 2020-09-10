using System.Data.Entity;

namespace MojaNawigacja.Models
{
    public class NawigacjaDbContext : DbContext
    {
        // Your context has been configured to use a 'NawigacjaDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MojaNawigacja.Models.NawigacjaDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'NawigacjaDbContext' 
        // connection string in the application configuration file.
        public NawigacjaDbContext()
            : base("name=NawigacjaDbContext")
        {
        }

        public DbSet<AdresyModel> Adresy { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
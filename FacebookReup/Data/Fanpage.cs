namespace FacebookReup.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Fanpage : DbContext
    {
        // Your context has been configured to use a 'Fanpage' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'FacebookReup.Data.Fanpage' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Fanpage' 
        // connection string in the application configuration file.
        public Fanpage()
            : base("name=Fanpage")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    public class MyEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string AccessToken { get; set; }
    }
}
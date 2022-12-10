namespace RentACar.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RentACar.Models.RentACarDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
<<<<<<< HEAD
=======
            ContextKey = "RentACar.Models.RentACarDbContext";
>>>>>>> refs/remotes/origin/master
        }

        protected override void Seed(RentACar.Models.RentACarDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

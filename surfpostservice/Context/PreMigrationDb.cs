using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

public class PreMigrationDb
{
  public static void Migrate(IApplicationBuilder app, bool isProduction)
  {
    using (var serviceScope = app.ApplicationServices.CreateScope())
    {
      Run(serviceScope.ServiceProvider.GetService<AppDbContext>(), isProduction);
    }
  }

  protected static void Run(AppDbContext context, bool isProduction)
  {
    if(isProduction)
    {
      try
      {
        Console.WriteLine("------------<> Apply Migrations to Target Provider");
        context.Database.Migrate();
      }
      catch(Exception ex)
      {
        Console.WriteLine("------<> Auto-Migration Failed - " + ex.Message);
      }
    }
  }

}
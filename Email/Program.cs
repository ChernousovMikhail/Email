using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.ReactiveUI;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Email
{
    class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args) => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace()
                .UseReactiveUI();
    }
    public class DbContextMail : DbContext
    {
        //Dbcontext implementation
        public DbContextMail(DbContextOptions options) : base(options)
        {
        }
    }

    public class YourDbContextFactory : IDesignTimeDbContextFactory<DbContextMail>
    {
        public DbContextMail CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbContextMail>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-VVUUKNK;Database=Pr;Trusted_Connection=True;");

            return new DbContextMail(optionsBuilder.Options);
        }
    }
}

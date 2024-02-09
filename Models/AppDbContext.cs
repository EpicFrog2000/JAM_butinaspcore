using Microsoft.EntityFrameworkCore;

namespace APP1.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=itpracujpl_db;uid=root;pwd=;");
        }
        //DailyItPracujPl

        public DbSet<DailyItPracujPl.daily_data> daily_data { get; set; }
        public DbSet<DailyItPracujPl.daily_etat> daily_etat { get; set; }
        public DbSet<DailyItPracujPl.daily_kontrakt> daily_kontrakt { get; set; }
        public DbSet<DailyItPracujPl.daily_management_level> daily_management_level { get; set; }
        public DbSet<DailyItPracujPl.daily_specjalizacje> daily_specjalizacje { get; set; }
        public DbSet<DailyItPracujPl.daily_technologie_mile_widziane> daily_technologie_mile_widziane { get; set; }
        public DbSet<DailyItPracujPl.daily_technologie_wymagane> daily_technologie_wymagane { get; set; }
        public DbSet<DailyItPracujPl.daily_work_type> daily_work_type { get; set; }

    }
}

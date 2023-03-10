using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Text.RegularExpressions;

namespace Project4._0_C3_CrowdCtrl_Back.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventRecordingDevice> EventRecordingDevices { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<EventUser> EventUsers { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupGuard> GroupGuards { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Mood> Moods { get; set; }
        public DbSet<MoodType> MoodTypes { get; set; }
        public DbSet<RecordingDevice> RecordingDevices { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RoleType> RoleTypes { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<IncidentType> IncidentTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<EventRecordingDevice>().ToTable("EventRecordingDevice");
            modelBuilder.Entity<EventType>().ToTable("EventType");
            modelBuilder.Entity<EventUser>().ToTable("EventUser");
            modelBuilder.Entity<Feedback>().ToTable("Feedback");
            modelBuilder.Entity<Group>().ToTable("Group");
            modelBuilder.Entity<GroupGuard>().ToTable("GroupGuard");
            modelBuilder.Entity<Incident>().ToTable("Incident");
            modelBuilder.Entity<Mood>().ToTable("Mood");
            modelBuilder.Entity<MoodType>().ToTable("MoodType");
            modelBuilder.Entity<RecordingDevice>().ToTable("RecordingDevice");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<RoleType>().ToTable("RoleType");
            modelBuilder.Entity<Zone>().ToTable("Zone");
            modelBuilder.Entity<IncidentType>().ToTable("IncidentType");
        }
    }
}

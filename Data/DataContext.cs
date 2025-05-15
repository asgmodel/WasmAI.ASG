
using AutoGenerator;
using AutoGenerator.Data;
using WasmAI.ASG.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace WasmAI.ASG.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WasmAI.ASG.Models;

public class DataContext : AutoIdentityDataContext<ApplicationUser, IdentityRole, string>, ITAutoDbContext
{
    // DbSets للنماذج اللي عندك
    public DbSet<Tactic> Tactics { get; set; }
    public DbSet<Technique> Techniques { get; set; }
    public DbSet<Software> Softwares { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<ScenarioType> ScenarioTypes { get; set; }
    public DbSet<Scenario> Scenarios { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<UserSoftware> UserSoftwares { get; set; }
    public DbSet<UserTactic> UserTactics { get; set; }
    public DbSet<UserScenario> UserScenarios { get; set; }
    public DbSet<UserTechnique> UserTechniques { get; set; }

    // إذا لديك موديلات إضافية تقدر تضيفها هنا
    // public DbSet<CategoryModel> Categories { get; set; }  // حسب الحاجة

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<Scenario>()
            .HasMany(s => s.Techniques)
            .WithMany(t => t.Scenarios);

        modelBuilder.Entity<Scenario>()
            .HasMany(s => s.Tactics)
            .WithMany(t => t.Scenarios);

        modelBuilder.Entity<Scenario>()
            .HasMany(s => s.Softwares)
            .WithMany(soft => soft.Scenarios);

        modelBuilder.Entity<Scenario>()
            .HasMany(s => s.Groups)
            .WithMany(g => g.Scenarios);

    

        modelBuilder.Entity<Group>()
            .HasMany(g => g.Softwares)
            .WithOne(s => s.Group)
            .HasForeignKey(s => s.GroupId);


        modelBuilder.Entity<UserSoftware>()
            .HasOne(us => us.ApplicationUser)
            .WithMany(u => u.UserSoftwares)
            .HasForeignKey(us => us.ApplicationUserId);

        modelBuilder.Entity<UserSoftware>()
            .HasOne(us => us.Software)
            .WithMany()
            .HasForeignKey(us => us.SoftwareId);

        modelBuilder.Entity<UserTactic>()
            .HasOne(ut => ut.ApplicationUser)
            .WithMany(u => u.UserTactics)
            .HasForeignKey(ut => ut.ApplicationUserId);

        modelBuilder.Entity<UserTactic>()
            .HasOne(ut => ut.Tactic)
            .WithMany()
            .HasForeignKey(ut => ut.TacticId);

        modelBuilder.Entity<UserScenario>()
            .HasOne(us => us.ApplicationUser)
            .WithMany(u => u.UserScenarios)
            .HasForeignKey(us => us.ApplicationUserId);

        modelBuilder.Entity<UserScenario>()
            .HasOne(us => us.Scenario)
            .WithMany()
            .HasForeignKey(us => us.ScenarioId);

        modelBuilder.Entity<UserTechnique>()
            .HasOne(ut => ut.ApplicationUser)
            .WithMany(u => u.UserTechniques)
            .HasForeignKey(ut => ut.ApplicationUserId);

        modelBuilder.Entity<UserTechnique>()
            .HasOne(ut => ut.Technique)
            .WithMany()
            .HasForeignKey(ut => ut.TechniqueId);

        modelBuilder.Entity<Question>()
            .HasOne(q => q.ApplicationUser)
            .WithMany(u => u.Questions)
            .HasForeignKey(q => q.ApplicationUserId);

        modelBuilder.Entity<Answer>()
            .HasOne(a => a.ApplicationUser)
            .WithMany(u => u.Answers)
            .HasForeignKey(a => a.ApplicationUserId);

        modelBuilder.Entity<Answer>()
            .HasOne(a => a.Question)
            .WithMany()
            .HasForeignKey(a => a.QuestionId);

        modelBuilder.Entity<Scenario>()
            .HasOne(s => s.ScenarioType)
            .WithMany(st => st.Scenarios)
            .HasForeignKey(s => s.ScenarioTypeId);
    }
}

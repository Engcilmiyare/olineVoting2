using Microsoft.EntityFrameworkCore;
using OnlineVotingSystem.Models;

namespace OnlineVotingSystem.Data
{
 
        public class OnlineVoteDbContext : DbContext
        {
        public OnlineVoteDbContext(DbContextOptions<OnlineVoteDbContext> options)
            : base(options)
        {
        }
        //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("OnlineVoteSystem",
        //        sqlOptions => sqlOptions.EnableRetryOnFailure(
        //            maxRetryCount: 5, // Number of retries
        //            maxRetryDelay: TimeSpan.FromSeconds(30), // Delay between retries
        //            errorNumbersToAdd: null)); // Add specific error numbers if needed
        //}
        public DbSet<Election> Elections { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        // Other DbSets

    }


}
    



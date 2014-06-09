using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using mvc5.Models;

namespace mvc5.Repositories
{
    public class MessageDatabase : DbContext
    {
        //connection string
        public MessageDatabase() : base("DefaultConnection") { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //1:1
            modelBuilder.Entity<User>()
                .HasRequired(u => u.Profile);

            modelBuilder.Entity<Message>()
                .HasRequired(u => u.Sender)
                .WithMany(u => u.SentMessages);

            modelBuilder.Entity<Message>()
                .HasRequired(u => u.Receiver)
                .WithMany(u => u.ReceivedMessages);

//            modelBuilder.Entity<User>()
//                .HasMany(u => u.SentMessages)
//                .WithRequired(u => u.Sender)
//                .HasForeignKey(h => h.SenderId);
//
//            modelBuilder.Entity<User>()
//                .HasMany(u => u.ReceivedMessages)
//                .WithRequired(m => m.Receiver)
//                .HasForeignKey(f => f.ReceiverId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
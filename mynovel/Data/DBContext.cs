using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mynovel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Data
{
    public class DBContext: IdentityDbContext<Reader>
    {
        public DBContext(DbContextOptions<DBContext>options):base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorNovel>().HasKey(sc => new { sc.AuthorId, sc.novelId });
            modelBuilder.Entity<ChapterAuthor>().HasKey(sc => new { sc.chapterId, sc.authorId});
            modelBuilder.Entity<UserNotification>().HasKey(sc => new { sc.userId, sc.notificationId });
        }
        public DbSet<Novel> Novels { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        public DbSet<AuthorNovel> authorNovels { get; set; }
        public DbSet<ChapterAuthor> chapterAuthors { get; set; }
        public DbSet<UserNotification> userNotifications { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UserRoles> User { get; set; }


    }
}

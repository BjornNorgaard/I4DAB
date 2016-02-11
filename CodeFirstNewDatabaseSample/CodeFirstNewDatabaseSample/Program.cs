using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                #region Creating new organization

                // Create and save new organization
                Console.WriteLine("Enter name for a new organization: ");
                string nameOrg = Console.ReadLine();

                Organization organization = new Organization { Name = nameOrg };
                db.Organizations.Add(organization);
                //db.SaveChanges(); // may not be needed, when saved later?

                #endregion

                #region Creating new user with association to previous org

                Console.WriteLine("Enter name for new user: ");
                string nameUser = Console.ReadLine();
                
                User user = new User { DisplayName = nameUser, OrganizationId = 0};

                db.Users.Add(user);

                #endregion

                #region Creating new Blog

                // Create and save new blog
                Console.Write("Enter a name for a new Blog: ");
                string nameBlog = Console.ReadLine();

                Blog blog = new Blog { Name = nameBlog };
                db.Blogs.Add(blog);

                #endregion

                db.SaveChanges();

                #region Print all Blogs in db

                // Display all Blogs from the database
                var blogsQuery = from b in db.Blogs
                                 orderby b.Name
                                 select b;

                Console.WriteLine("All Blogs in the database:");
                foreach (var item in blogsQuery)
                {
                    Console.WriteLine(item.Name);
                }

                #endregion

                #region Print all Orgs in db

                // Display all Organizations from the db
                var organizatinoQuery = from o in db.Organizations
                                        orderby o.Name
                                        select o;

                Console.WriteLine("All Organizations in the db:");
                foreach (var organization1 in organizatinoQuery)
                {
                    Console.WriteLine(organization1.Name);
                }

                #endregion

                #region Waiting to close connection

                // Waiting to close connection
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();

                #endregion

            }
        }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        // Why is this virtual?
        public virtual List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }

    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Organization> Organizations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .Property(u => u.DisplayName)
                .HasColumnName("display_name");
        }
    }

    public class User
    {
        [Key]
        public string Username { get; set; }
        public string DisplayName { get; set; }

        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }
    }

    public class Organization
    {
        public int OrganizationId { get; set; }
        public string Name { get; set; }

        public virtual List<User> Users { get; set; }
    }
}

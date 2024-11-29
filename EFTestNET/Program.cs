using System;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Linq;
using EFTestNET.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

namespace EFTestNET
{
    //Scaffold-DbContext "Server=(localdb)\MSSQLLocalDB;Database=EFTestDb;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Exercises\Model
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AddUsers();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            Console.ReadKey();
        }

        static void AddUsers()
        {
            using (var dbCtx = new EFTestDbContext())
            {
                try
                {
                    //dbCtx.Users.RemoveRange(dbCtx.Users);
                    //dbCtx.Groups.RemoveRange(dbCtx.Groups);
                    //dbCtx.UserGroups.RemoveRange(dbCtx.UserGroups);
                    Func<int, int, bool> del = null;
                    var activeJUsers = dbCtx.Users
                        .Where(u => u.IsActive && u.Name.StartsWith("J"))
                        .Include(u => u.UserGroups)
                        .ThenInclude(u => u.Group);  //Regex.Match()  new Regex().Match()

                    //var filtered = activeJUsers.Where(x => del(0, 0));



                    var userWithGroups = dbCtx
                        .Users
                        .Where(u => u.IsActive)
                        .Select(u => new
                        {
                            UserName = u.Name,
                            GroupNames = u.UserGroups.Select(x => x.Group.Name).ToArray()
                        });



                    var user = activeJUsers.FirstOrDefault();
                    user.Name = "asdlfk";



                    user = activeJUsers.FirstOrDefault();
                    user.Name = "gfdsdfgfd";


                    dbCtx.SaveChanges();


                    //dbCtx.Users.FromSqlRaw("SELECT FROM Users WHERE IsActive = 1 AND Name LIKE 'J%'");
                    //"SELECT FROM Users WHERE IsActive = 1 AND Name LIKE 'J%' "


                    var userId = dbCtx.Users.Max(el => el.Id);
                    var groupId = dbCtx.Groups.Max(el => el.Id);

                    var entityuser = dbCtx.Users.Add(new User { Name = "John", Password = "Password", IsActive = true });

                    EntityEntry<Group> group = null;
                    if (!dbCtx.Groups.Any(el => el.Name == "Administrator"))
                    {
                        group = dbCtx.Groups.Add(new Group {Id = groupId + 1,  Name = "Administrator" });
                    }
                    //var users = dbCtx.Users.Include(e => e.Name).ToList();
                    dbCtx.SaveChanges();

                    if (group != null)
                    {
                        var userGroupId = dbCtx.UserGroups.Max(el => el.Id);
                        var userGroup = dbCtx.UserGroups.Add(new UserGroup() { Id = userGroupId + 1, GroupId = group.Entity.Id, UserId = entityuser.Entity.Id });

                        dbCtx.SaveChanges();

                        var c = entityuser.Entity.UserGroups.Count;
                    }
                    var count = dbCtx.Users.First().UserGroups.Count;

                    dbCtx.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}

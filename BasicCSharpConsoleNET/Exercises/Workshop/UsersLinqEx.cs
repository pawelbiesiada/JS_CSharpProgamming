﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicCSharpConsoleNET.Samples.Class;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class UsersLinqEx
    {
        public void Test()
        {
            var users = CreateCollection.GetUsers();

            var hasAnyElement = users.Any();

            //var nonNullItemsCount = users.Where(u => u != null).Count();
            var nonNullItemsCount = users.Count(u => u != null);

            var mUsers = users.Where(u => u.Name.StartsWith("M"));
            foreach (var user in mUsers)
            { Console.WriteLine(user.Name); }

            var top5Users = users.Take(5).OrderBy(u => u.Name);
            //var top5Users = users.OrderBy(u => u.Name).Take(5);

            var secondTop5Users = users.OrderBy(u => u.Name).Skip(5).Take(5);

            var pageNr = 7;
            var itemsPerPage = 10;
            var pageitems = users.Skip(pageNr*itemsPerPage).Take(itemsPerPage);

            var distinctUserNames = users.Select(u => u.Name).Distinct();

            var cars = users.Select(u => new Car(u.Id));

        }
    }
}
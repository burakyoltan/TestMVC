using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace eTicaretMVC.Identity
{
    public class IdentityInitializer: CreateDatabaseIfNotExists <IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {


            //Roller
            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role=new ApplicationRole(){Name = "admin",Description = "admin Rolü"};
                manager.Create(role);
            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "user", Description = "user Rolü" };
                manager.Create(role);
            }





            //User

            if (!context.Roles.Any(i => i.Name == "burakyoltan"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser(){Name = "burak",Surname = "yoltan",UserName = "burakyoltan",Email = "burakyoltann@gmail.com"};


                manager.Create(user,"123456");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }




            if (!context.Roles.Any(i => i.Name == "tarikyoltan"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "tarik",Surname = "yoltan", UserName = "tarikyoltan", Email = "tarik@gmail.com" };


                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "user");
            }




            base.Seed(context);
        }
    }
}
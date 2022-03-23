namespace Contact_list.DAL.Migrations
{
    using Contact_list.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Contact_list.DAL.DataAccess.AppliactionDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Contact_list.DAL.DataAccess.AppliactionDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            if (!context.Addresses.Any() && !context.Contacts.Any())
            {
                var addresses = new List<Address>()
                {
                    new Address(0, "Armenia", "Yerevan", "Mamikonyanc", "52", "1"),
                    new Address(1, "Armenia", "Yerevan", "Abovyan", "12", "1"),
                    new Address(2, "Armenia", "Yerevan", "Tumanyan", "78", "6")
                };

                var contacts = new List<Contact>()
                {
                    new Contact(0, "Ashot", "Mkhitaryan","mkhitaryan.ashoth@gmail.com", "093103365", addresses.FirstOrDefault().Id),
                    new Contact(1, "Hayk", "Ghevondyan","g.hayk@gmail.com", "045113265", addresses.FirstOrDefault().Id),
                    new Contact(2, "Levon", "Fermanyan","levon.fermanyan@gmail.com", "098985623", addresses.LastOrDefault().Id)
                };

                context.Addresses.AddRange(addresses);
                context.Contacts.AddRange(contacts);

                context.SaveChanges();
            }
        }
    }
}

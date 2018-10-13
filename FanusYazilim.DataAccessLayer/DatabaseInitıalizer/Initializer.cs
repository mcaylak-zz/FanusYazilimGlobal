using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FanusYazilim.DataAccessLayer.EntityFramework;
using FanusYazilim.Entities;
using FanusYazilim.Entities.Hash_SHA1;

namespace FanusYazilim.DataAccessLayer.DatabaseInitıalizer
{
    public class Initializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            User _user = new User()
            {
                Email = "emircnaslan@gmail.com".ToLower(),
                Password = Sha.Encoder("admin123"),
                SecurityGuid = Guid.NewGuid()
            };

            context.Users.Add(_user);
            context.SaveChanges();

        }
    }
}

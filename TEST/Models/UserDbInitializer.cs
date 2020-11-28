using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TEST.Models
{
    public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            db.Users.Add(new User { First_Name = "Aidanbek", Last_Name = "Kamalov", Age=23, Gender="Male", Country="Kazakhstan", Email="kamalov23@gmail.com" });
            db.Users.Add(new User { First_Name = "Ruslan", Last_Name = "Olegov", Age = 19, Gender = "Male", Country = "Russia", Email = "rusya228@mail.ru" });
            db.Users.Add(new User { First_Name = "Helena", Last_Name = "Soretti", Age = 21, Gender = "Female", Country = "Italia", Email = "SsSoretti@gmail.com" });

            base.Seed(db);
        }
    }
}
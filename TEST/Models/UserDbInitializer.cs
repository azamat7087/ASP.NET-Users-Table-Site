using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TEST.Models
{
    public class UserDbInitializer : CreateDatabaseIfNotExists<UserContext>
    {
       
    }
}
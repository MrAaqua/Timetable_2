using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Timetable.Models
{
    public class AppUserModel:IdentityUser
    {
        public string PostAddress { get; set; }

        public string Position { get; set; }

        public string FullName { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models
{
    public class CustomizeUser : IdentityUser
    {
        [PersonalData]
        public string Fullname { get; set; }

    }
}

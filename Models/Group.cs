﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EFcore
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }

    }

}
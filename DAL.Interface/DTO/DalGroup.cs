﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.DTO
{
    public class DalGroup : IDalEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class RawMaterialRepository : BaseRepository<RawMaterial>
    {
        public RawMaterialRepository(SqlContext context) : base(context)
        {
        }
    }
}

﻿using GeeksBakery.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.Data.Configurations
{
    public class CakeImageConfiguration : IEntityTypeConfiguration<CakeImage>
    {
        public void Configure(EntityTypeBuilder<CakeImage> builder)
        {
            
        }
    }
}

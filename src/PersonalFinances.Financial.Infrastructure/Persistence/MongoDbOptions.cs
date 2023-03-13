﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinances.Financial.Infrastructure.Persistence
{
    public class MongoDbOptions
    {
        public string Database { get; set; }
        public string ConnectionString { get; set; }
    }
}

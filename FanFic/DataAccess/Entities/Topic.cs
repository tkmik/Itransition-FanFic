﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<FanFicTopic> FanFics { get; set; }
    }
}

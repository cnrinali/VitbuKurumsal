﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class Log
    {
        public Guid Id { get; set; }
        public string Tarih { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }
}

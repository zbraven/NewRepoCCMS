﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMMS.Services.DTOs
{
    public class ReportDto
    {
        public int Id { get; set; }
        public int ActivityLogId { get; set; }
        public string FilePath { get; set; }
    }
}

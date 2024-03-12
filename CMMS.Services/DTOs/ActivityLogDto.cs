﻿using CMMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace CMMS.Services.DTOs
{
    public class ActivityLogDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public int EmployeeId { get; set; }
        public int MaintenanceTaskId { get; set; }
        public virtual MaintenanceTask MaintenanceTask { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }

}
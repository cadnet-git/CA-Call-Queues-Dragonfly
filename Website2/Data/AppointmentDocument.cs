﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Website2
{
    public partial class AppointmentDocument
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public int? UserId { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace GTAVehicles.Models
{
    public partial class GtavehicleClass
    {
        public GtavehicleClass()
        {
            Gtavehicles = new HashSet<Gtavehicles>();
        }

        public int Id { get; set; }
        public string ClassName { get; set; }

        public virtual ICollection<Gtavehicles> Gtavehicles { get; set; }
    }
}
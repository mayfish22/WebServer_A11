﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebServer.Models.WebServerDB;

public partial class Card
{
    public string ID { get; set; }

    public string CardNo { get; set; }

    public string UserID { get; set; }

    public virtual ICollection<CardHistory> CardHistory { get; } = new List<CardHistory>();

    public virtual User User { get; set; }
}
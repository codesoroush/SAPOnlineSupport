﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAPOSModel.Entities
{
    public class SAPOSUser:IdentityUser
    {
        public string FullName { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public Guid UserId { get; set; } = Guid.NewGuid();
        public long TickId { get; set; }
        public string ConnectionId { get; set; }
        public int OnlineStatus { get; set; }
        public string CurrentIp { get; set; }
        public string OS { get; set; }
        public DateTime LastActiveDate { get; set; }
        public int Gender { get; set; }


    }
}

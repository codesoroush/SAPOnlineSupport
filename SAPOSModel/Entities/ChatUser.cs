using SAPOSModel.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAPOSModel.Entities
{
    public class ChatUser
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public DateTime BirthDate { get; set; } = DateTime.Now;

        public Guid UserId { get; set; } = Guid.NewGuid();
        public long TickId { get; set; }
        public string ConnectionId { get; set; }
        public OnlineStatus OnlineStatus { get; set; }
        public string CurrentIp { get; set; }
        public string OS { get; set; }
        public DateTime LastActiveDate { get; set; }
        public Gender Gender { get; set; }
    }
}

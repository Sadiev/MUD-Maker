using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mud_Maker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Mud> Muds { get; set; }
        public DbSet<Event> Events { get; set; }
        public class Mud
        {
            public int MudId { get; set; }
            public string MudName { get; set; }
            public string MudDescription { get; set; }
        }
        public class Event
        {
            public int EventId { get; set; }
            public string EventName { get; set; }
            public string EventDescription { get; set; }
            public bool EventTriggered { get; set; }
            public char? DirLeft { get; set; }
            public char? DirRight { get; set; }
            public char? DirFwd { get; set; }


            public Mud Mud { get; set; }
            public int MudId { get; set; }

            public EventType EventType { get; set; }
            public int EventTypeId { get; set; }
        }

        public class EventType
        {
            public int EventTypeId { get; set; }

            public Event Event { get; set; }
            public int EventId { get; set; }


        }
    }
}

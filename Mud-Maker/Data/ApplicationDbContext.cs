﻿using System;
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
        public DbSet<EventType> EventTypes{ get; set; }
        public DbSet<Fight> Fights { get; set; }
        public DbSet<Health> HealthBar { get; set; }
        public DbSet<Item> Items { get; set; }

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
                                 
            public EventType EventType { get; set; }
            public int EventTypeId { get; set; }

            // public Mud Mud { get; set; }
            // public int MudId { get; set; }
        }

        public class EventType
        {
            public int EventTypeId { get; set; }
            public int FightId { get; set; }
            public int HealthId { get; set; }
            public int ItemId { get; set; }

            // public Event Event { get; set; }
            // public int EventId { get; set; }
        }

        public class Fight
        {
            public int FightId { get; set; }
            public int Health { get; set; }
            public int AttackPower { get; set; }
            public string Name { get; set; }

            // public int EventTypeId { get; set; }
        }

        public class Health
        {
            public int HealthId { get; set; }
            public bool IsGained { get; set; }
            public int Amount { get; set; }

            // public int EventTypeId { get; set; }
        }

        public class Item
        {
            public int ItemId { get; set; }
            public bool IsGained { get; set; }
            public string Object { get; set; }

            // public int EventTypeId { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Mud_Maker.Data;

namespace Mud_Maker.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Muds.Any())
            {
                context.Muds.AddRange(
                        new Mud
                        {
                            //MudId = 00001,
                            MudName = "This is Jay's Mud Name.",
                            MudDescription = "This is Jay's Mud Description. Jay loves to make muds. It is his favorite."
                        },

                        new Mud
                        {
                            //MudId = 00002,
                            MudName = "This is Jordan's Mud Name.",
                            MudDescription = "This is Jordan's Mud Description. Jordan really made a mess of this mud."
                        }
                );
                context.SaveChanges();
            }

            if (!context.Events.Any())

                context.Events.AddRange(
                        new Event
                        {
                            EventId = 10001,
                            EventName = "Philly Special",
                            EventDescription = "You are about to witness the GREATEST play in NFL history",
                            EventText = "It's 4th and Goal. The Biggest game of your lifetime. The stakes could not be higher. Do you have the gumption to pull this off?",
                            EventTriggered = false,
                            DirLeft = 10002,
                            DirRight = null,
                            DirFwd = 10003,
                            DirBack = null, // if DirBack remains null => this is the starting event?
                            //EventTypeId = 00001,
                            MudId = 00001
                        },

                        new Event
                        {
                            EventId = 10002,
                            EventName = "Miracle at the Meadowlands",
                            EventDescription = "The Miracle at the Meadowlands was a fumble recovery by cornerback Herman Edwards that he returned for a touchdown at the end of a November 19, 1978",
                            EventText = "Everyone watching expected quarterback Joe Pisarcik to take one more snap and kneel with the ball, thus running out the clock and preserving a 17–12 Giants upset. Instead, he botched an attempt to hand off the football to fullback Larry Csonka. Edwards picked up the dropped ball and ran 26 yards for the winning score.",
                            EventTriggered = false,
                            DirLeft = null,
                            DirRight = null,
                            DirFwd = null,
                            DirBack = 10001,
                            //EventTypeId = 00002,
                            MudId = 00001
                        },

                        new Event
                        {
                            EventId = 10003,
                            EventName = "Miracle at the Meadowlands II",
                            EventDescription = "Improbable come-from-behind win by the Philadelphia Eagles over rival team the New York Giants at New Meadowlands Stadium on December 19, 2010",
                            EventText = "With just over eight minutes to play in the fourth quarter, the Eagles trailed the Giants by 21 points. They went on to score four unanswered touchdowns in the final seven minutes and 28 seconds of play, including a punt returned for a touchdown by DeSean Jackson as time expired. Jackson became the first player in NFL history to win a game by scoring on a punt return as time expired. The win allowed the Eagles to progress to the 2010 NFL playoffs by head-to-head tiebreaker over the Giants, where they lost to eventual Super Bowl champion Green Bay Packers.",
                            EventTriggered = false,
                            DirLeft = null,
                            DirRight = null,
                            DirFwd = null,
                            DirBack = 10001,
                            //EventTypeId = 00002,
                            MudId = 00001
                        },

                        new Event
                        {
                            EventId = 10001,
                            EventName = "Miracle at the Meadowlands",
                            EventDescription = "The Miracle at the Meadowlands was a fumble recovery by cornerback Herman Edwards that he returned for a touchdown at the end of a November 19, 1978",
                            EventText = "Everyone watching expected quarterback Joe Pisarcik to take one more snap and kneel with the ball, thus running out the clock and preserving a 17–12 Giants upset. Instead, he botched an attempt to hand off the football to fullback Larry Csonka. Edwards picked up the dropped ball and ran 26 yards for the winning score.",
                            EventTriggered = false,
                            DirLeft = null,
                            DirRight = null,
                            DirFwd = null,
                            DirBack = 10001,
                            //EventTypeId = 00002,
                            MudId = 00001
                        },

                        new Event
                        {
                            EventId = 10003,
                            EventName = "Miracle at the Meadowlands II",
                            EventDescription = "Improbable come-from-behind win by the Philadelphia Eagles over rival team the New York Giants at New Meadowlands Stadium on December 19, 2010",
                            EventText = "With just over eight minutes to play in the fourth quarter, the Eagles trailed the Giants by 21 points. They went on to score four unanswered touchdowns in the final seven minutes and 28 seconds of play, including a punt returned for a touchdown by DeSean Jackson as time expired. Jackson became the first player in NFL history to win a game by scoring on a punt return as time expired. The win allowed the Eagles to progress to the 2010 NFL playoffs by head-to-head tiebreaker over the Giants, where they lost to eventual Super Bowl champion Green Bay Packers.",
                            EventTriggered = false,
                            DirLeft = null,
                            DirRight = null,
                            DirFwd = null,
                            DirBack = 10001,
                            //EventTypeId = 00002,
                            MudId = 00001
                        }

                ); ;
            context.SaveChanges();
        }
    }
}

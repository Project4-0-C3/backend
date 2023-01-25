using Microsoft.EntityFrameworkCore;
using Project4._0_C3_CrowdCtrl_Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Group = Project4._0_C3_CrowdCtrl_Back.Models.Group;

namespace Project4._0_C3_CrowdCtrl_Back.Data
{
    public class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DataContext>>()))
            {
                // Look for any EventTypes.
                //if (context.EventTypes.Any())
                //{
                //    return;   // DB has been seeded
                //}

                //// Add EventTypes
                //context.AddRange(
                //    new EventType { Name = "Gala", Threshold = 0.1 },
                //    new EventType { Name = "Football", Threshold = 0.8 },
                //    new EventType { Name = "Party", Threshold = 0.50 },
                //    new EventType { Name = "Proclamation", Threshold = 0.20 }
                //    );

                //context.SaveChanges();

                //// Look for any Events.
                //if (context.Events.Any())
                //{
                //    return;   // DB has been seeded
                //}

                ////Add Events
                //context.AddRange(
                //    new Event { Date = DateTime.Now, Name = "Thomas More Geel", Location = "Kleinhoefstraat 4, Geel", Description = "This would be a description for an event", EventTypeId = 4 },
                //    new Event { Date = DateTime.Now, Name = "KVV Noordstar - KFC Oever", Location = "Tarwestraat 7-31, Herentals", Description = "This would be a description for an event", EventTypeId = 2 },
                //    new Event { Date = DateTime.Now, Name = "EasterBunny Party", Location = "Konijnenber 13, Turnhout", Description = "This would be a description for an event", EventTypeId = 3 },
                //    new Event { Date = DateTime.Now, Name = "Thomas More Lier", Location = "Antwerpsestraat 99, Lier", Description = "This would be a description for an event", EventTypeId = 4 },
                //    new Event { Date = DateTime.Now, Name = "KRC Genk - KVC Westerlo", Location = "Stadionplein 4, Genk", Description = "This would be a description for an event", EventTypeId = 2 },
                //    new Event { Date = DateTime.Now, Name = "Carnival", Location = "Rio de Janeiro, Brasil", Description = "This would be a description for an event", EventTypeId = 2 }
                //    );

                //context.SaveChanges();

                //Look for any Users.
                //if (context.Users.Any())
                //    {
                //        return;   // DB has been seeded
                //    }

                ////Add Users
                //context.AddRange(
                //    //new User { FirstName = "Jari", LastName = "Van de Vel", Email = "vandeveljari@outlook.com", RoleTypeId = 1 },
                //    new User { FirstName = "Renzo", LastName = "Beeckmans", Email = "rebe11@gmail.com", RoleTypeId = 2 },
                //    new User { FirstName = "Robin", LastName = "Ram", Email = "robin@ram.com", RoleTypeId = 2 },
                //    new User { FirstName = "John", LastName = "Banko", Email = "johnbanko@gmail.com", RoleTypeId = 2 },
                //    new User { FirstName = "Bert", LastName = "Janssens", Email = "bertjanssens@gmail.com", RoleTypeId = 2 },
                //    new User { FirstName = "Jan", LastName = "Peeters", Email = "peetersj@gmail.com", RoleTypeId = 2 },
                //    new User { FirstName = "Jonas", LastName = "Van den Berg", Email = "jonasvandenberg@outlook.com", RoleTypeId = 3, PhoneNumber = "0472893644" },
                //    new User { FirstName = "Victor", LastName = "Verhavert", Email = "victorverhavert@gmail.com", RoleTypeId = 3, PhoneNumber = "0473593644" },
                //    new User { FirstName = "Arne", LastName = "Vanhove", Email = "vanhovearne@gmail.com", RoleTypeId = 3, PhoneNumber = "0491193644" },
                //    new User { FirstName = "Jesse", LastName = "Dierckx", Email = "jessedierckx@gmail.com", RoleTypeId = 3, PhoneNumber = "0221893644" },
                //    new User { FirstName = "Tim", LastName = "Verbecque", Email = "verbecquet@gmail.com", RoleTypeId = 3, PhoneNumber = "0472921644" },
                //    new User { FirstName = "Lenn", LastName = "Van Genechten", Email = "lennvangenechten@gmail.com", RoleTypeId = 3, PhoneNumber = "0472619644" }
                //    );

                //context.SaveChanges();

                ////Look for any Guards.
                //if (context.Guards.Any())
                //{
                //    return;   // DB has been seeded
                //}
                //context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Guard] ON");
                //context.SaveChanges();

                ////Add Guards
                //context.AddRange(
                //    new Guard { FirstName = "Jonas", LastName = "Van den Berg", Email = "jonasvandenberg@outlook.com", UserTypeId = 1, PhoneNumber = "0472893644" },
                //    new Guard { FirstName = "Victor", LastName = "Verhavert", Email = "victorverhavert@gmail.com", UserTypeId = 1, PhoneNumber = "0473593644" },
                //    new Guard { FirstName = "Arne", LastName = "Vanhove", Email = "vanhovearne@gmail.com", UserTypeId = 1, PhoneNumber = "0491193644" },
                //    new Guard { FirstName = "Jesse", LastName = "Dierckx", Email = "jessedierckx@gmail.com", UserTypeId = 1, PhoneNumber = "0221893644" },
                //    new Guard { FirstName = "Tim", LastName = "Verbecque", Email = "verbecquet@gmail.com", UserTypeId = 1, PhoneNumber = "0472921644" },
                //    new Guard { FirstName = "Lenn", LastName = "Van Genechten", Email = "lennvangenechten@gmail.com", UserTypeId = 1, PhoneNumber = "0472619644" }
                //    );

                //context.SaveChanges();
                //context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Guard] OFF");

                // Look for any Zones.
                //if (context.Zones.Any())
                //{
                //    return;   // DB has been seeded
                //}

                ////Add Zones
                //context.AddRange(
                //    new Zone { Name = "Alfa" },
                //    new Zone { Name = "Beta" },
                //    new Zone { Name = "Gamma" }
                //    );

                //context.SaveChanges();



                //// Look for any EventUsers.
                //if (context.EventUsers.Any())
                //{
                //    return;   // DB has been seeded
                //}

                ////Add EventUsers
                //context.AddRange(
                //    new EventUser { EventId = 1, UserId = 2 },
                //    new EventUser { EventId = 1, UserId = 3 },
                //    new EventUser { EventId = 1, UserId = 4 },
                //    new EventUser { EventId = 1, UserId = 5 },
                //    new EventUser { EventId = 1, UserId = 6 },
                //    new EventUser { EventId = 1, UserId = 49 },
                //    new EventUser { EventId = 2, UserId = 50 },
                //    new EventUser { EventId = 2, UserId = 51 },
                //    new EventUser { EventId = 2, UserId = 52 },
                //    new EventUser { EventId = 2, UserId = 53 },
                //    new EventUser { EventId = 2, UserId = 2 }
                //    );

                //context.SaveChanges();

                //// Look for any RecordingDevices.
                //if (context.RecordingDevices.Any())
                //{
                //    return;   // DB has been seeded
                //}

                ////Add RecordingDevices
                //context.AddRange(
                //    new RecordingDevice { Name = "RB32F7" },
                //    new RecordingDevice { Name = "RB37G3" },
                //    new RecordingDevice { Name = "R1FB32" },
                //    new RecordingDevice { Name = "R9KCB4" },
                //    new RecordingDevice { Name = "JV1221" },
                //    new RecordingDevice { Name = "JD136G" },
                //    new RecordingDevice { Name = "TV3FD1" },
                //    new RecordingDevice { Name = "5RHRR3" },
                //    new RecordingDevice { Name = "LVG125" },
                //    new RecordingDevice { Name = "KO2N0W" }
                //    );

                //context.SaveChanges();

                ////Look for any EventRecordingDevices.
                //if (context.EventRecordingDevices.Any())
                //{
                //    return;   // DB has been seeded
                //}

                ////Add EventRecordingDevices
                //context.AddRange(
                //    new EventRecordingDevice { PlacementName = "Bathroom Men", ZoneId = 1, RecordingDeviceId = 1, EventId = 1 },
                //    new EventRecordingDevice { PlacementName = "Bathroom Women", ZoneId = 1, RecordingDeviceId = 2, EventId = 1 },
                //    new EventRecordingDevice { PlacementName = "Entrance", ZoneId = 1, RecordingDeviceId = 3, EventId = 1 },
                //    new EventRecordingDevice { PlacementName = "Ticket Sale", ZoneId = 2, RecordingDeviceId = 4, EventId = 1 },
                //    new EventRecordingDevice { PlacementName = "Lounge", ZoneId = 2, RecordingDeviceId = 5, EventId = 1 },
                //    new EventRecordingDevice { PlacementName = "Exit 1", ZoneId = 2, RecordingDeviceId = 6, EventId = 1 },
                //    new EventRecordingDevice { PlacementName = "Exit 2", ZoneId = 3, RecordingDeviceId = 7, EventId = 1 },
                //    new EventRecordingDevice { PlacementName = "Exit 3", ZoneId = 3, RecordingDeviceId = 8, EventId = 1 },
                //    new EventRecordingDevice { PlacementName = "Buffet", ZoneId = 3, RecordingDeviceId = 9, EventId = 1 },
                //    new EventRecordingDevice { PlacementName = "Bar", ZoneId = 3, RecordingDeviceId = 10, EventId = 1 },
                //    new EventRecordingDevice { PlacementName = "Entrance", ZoneId = 1, RecordingDeviceId = 1, EventId = 2 }
                //    );

                //context.SaveChanges();

                // Look for any MoodTypes.
                //if (context.MoodTypes.Any())
                //{
                //    return;   // DB has been seeded
                //}

                ////Add MoodTypes
                //context.AddRange(
                //    new MoodType { Name = "Negative" },
                //    new MoodType { Name = "Neutral" },
                //    new MoodType { Name = "Positive" }

                //    );

                //context.SaveChanges();

                //// Look for any Moods.
                //if (context.Moods.Any())
                //{
                //    return;   // DB has been seeded
                //}

                ////Add Moods
                //context.AddRange(
                //    //new Mood { Accuracy = 0.98, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 1, EventRecordingDeviceId = 1 },
                //    new Mood { Accuracy = 0.76, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 1, EventRecordingDeviceId = 2 },
                //    new Mood { Accuracy = 0.90, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 1, EventRecordingDeviceId = 3 },
                //    new Mood { Accuracy = 0.88, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 2, EventRecordingDeviceId = 4 },
                //    new Mood { Accuracy = 0.99, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 2, EventRecordingDeviceId = 5 },
                //    new Mood { Accuracy = 0.79, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 2, EventRecordingDeviceId = 6 },
                //    new Mood { Accuracy = 0.98, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 3, EventRecordingDeviceId = 7 },
                //    new Mood { Accuracy = 0.98, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 3, EventRecordingDeviceId = 8 },
                //    //new Mood { Accuracy = 0.95, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 3, EventRecordingDeviceId = 1 },
                //    new Mood { Accuracy = 0.92, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 2, EventRecordingDeviceId = 11 }

                //    );

                //context.SaveChanges();

                //// Look for any IncidentTypes.
                //if (context.IncidentTypes.Any())
                //{
                //    return;   // DB has been seeded
                //}

                ////Add IncidentTypes
                //context.AddRange(
                //    new IncidentType { Name = "Applause" },
                //    new IncidentType { Name = "Thunder" },
                //    new IncidentType { Name = "Panic" },
                //    new IncidentType { Name = "Sirene" },
                //    new IncidentType { Name = "Fireworks" }

                //    );

                //context.SaveChanges();

                //// Look for any Incidents.
                //if (context.Incidents.Any())
                //{
                //    return;   // DB has been seeded
                //}

                ////Add Incidents
                //context.AddRange(
                //    new Incident { IncidentTypeId = 1, Accuracy = 0.98, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 1, EventRecordingDeviceId = 4 },
                //    new Incident { IncidentTypeId = 1, Accuracy = 0.76, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 1, EventRecordingDeviceId = 4 },
                //    new Incident { IncidentTypeId = 1, Accuracy = 0.90, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 2, EventRecordingDeviceId = 4 },
                //    new Incident { IncidentTypeId = 2, Accuracy = 0.88, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 1, EventRecordingDeviceId = 4 },
                //    new Incident { IncidentTypeId = 2, Accuracy = 0.99, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 2, EventRecordingDeviceId = 2 },
                //    new Incident { IncidentTypeId = 2, Accuracy = 0.79, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 3, EventRecordingDeviceId = 2 },
                //    new Incident { IncidentTypeId = 3, Accuracy = 0.98, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 2, EventRecordingDeviceId = 3 },
                //    new Incident { IncidentTypeId = 3, Accuracy = 0.98, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 1, EventRecordingDeviceId = 3 },
                //    new Incident { IncidentTypeId = 3, Accuracy = 0.95, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 1, EventRecordingDeviceId = 3 },
                //    new Incident { IncidentTypeId = 4, Accuracy = 0.92, StartTime = DateTime.Now, EndTime = DateTime.Now, MoodTypeId = 2, EventRecordingDeviceId = 4 }

                //    );

                //context.SaveChanges();

                ////Look for any Groups.
                //if (context.Groups.Any())
                //    {
                //        return;   // DB has been seeded
                //    }

                ////Add Groups
                //context.AddRange(
                //    new Group { Name = "Group 1", ZoneId = 1, EventId = 1 },
                //    new Group { Name = "Group 2", ZoneId = 2, EventId = 1 },
                //    new Group { Name = "Group 3", ZoneId = 3, EventId = 1 },
                //    new Group { Name = "Group 1", ZoneId = 1, EventId = 2 },
                //    new Group { Name = "Group 2", ZoneId = 2, EventId = 2 }
                //    );

                //context.SaveChanges();

                //// Look for any GroupGuards.
                //if (context.GroupGuards.Any())
                //{
                //    return;   // DB has been seeded
                //}

                ////Add GroupGuards
                //context.AddRange(
                //    new GroupGuard { UserId = 49, GroupId = 1 },
                //    new GroupGuard { UserId = 50, GroupId = 1 },
                //    new GroupGuard { UserId = 51, GroupId = 2 },
                //    new GroupGuard { UserId = 52, GroupId = 2 },
                //    new GroupGuard { UserId = 53, GroupId = 3 },
                //    new GroupGuard { UserId = 52, GroupId = 4 }
                //    );

                //context.SaveChanges();

                //// Look for any UserTypes.
                //if (context.RoleTypes.Any())
                //{
                //    return;   // DB has been seeded
                //}

                ////Add UserTypes
                //context.AddRange(
                //    new RoleType { Name = "Admin" },
                //    new RoleType { Name = "Teamlead" },
                //    new RoleType { Name = "Guard" }
                //    );

                //context.SaveChanges();
            }
        }
    }
}
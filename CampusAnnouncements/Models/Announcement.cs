using System;

namespace CampusAnnouncements.Models
{
    public class Announcement
    {
        public required string Title {get;set;}
        public required string Content {get;set;}
        public DateTime DatePost {get;set;}
    }
}

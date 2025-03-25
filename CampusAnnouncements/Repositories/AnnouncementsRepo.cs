using System.Collections.Generic;
using System;
using CampusAnnouncements.Models;

namespace CampusAnnouncements.Repositories
{
    public class AnnouncementRepository
    {
        private static List<Announcement> announcements = new List<Announcement>
        {
            // new Announcement { Title = "Exam Schedule", Content = "The exam timetable is available.", DatePosted = DateTime.Now },
        };

        public List<Announcement> GetAllMyPost()
        {
            return announcements;
        }

        public void Add(Announcement announcement)
        {
            announcement.DatePost = DateTime.Now;
            announcements.Add(announcement);
        }
    }
}

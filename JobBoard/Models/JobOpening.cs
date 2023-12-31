using System;
using System.Collections.Generic;


namespace JobBoard.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class JobOpening
    {
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public Contact JobContactInfo { get; set; }
        public int JobOpeningId { get; set; }

        private static List<JobOpening> _listOfJobs = new List<JobOpening>();
        
        
        

        public JobOpening(string myJobTitle, string myJobDescription, Contact myJobContactInfo)
        {
            JobTitle = myJobTitle;
            JobDescription = myJobDescription;
            JobContactInfo = myJobContactInfo;
            _listOfJobs.Add(this);
            JobOpeningId = _listOfJobs.Count;
        }

        public static List<JobOpening> GetAllJobs()
        {
            return _listOfJobs;
        }

        public static void RemoveAllJobs()
        {
            _listOfJobs.Clear();
        }

        public static JobOpening FindJob(int jobId)
        {
            return _listOfJobs[jobId-1];
        }
        
    }
}
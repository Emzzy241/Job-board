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
        
        
        

        public JobOpening(string myJobTitle, string myJobDescription, Contact myJobContactInfo)
        {
            JobTitle = myJobTitle;
            JobDescription = myJobDescription;
            JobContactInfo = myJobContactInfo;
        }
        
    }
}
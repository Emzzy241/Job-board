using System;
using System.Collections.Generic;


namespace JobBoard.Models
{
    public class JobOpening
    {
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        

        public JobOpening(string myJobTitle, string myJobDescription)
        {
            JobTitle = myJobTitle;
            JobDescription = myJobDescription;
        }
        
    }
}
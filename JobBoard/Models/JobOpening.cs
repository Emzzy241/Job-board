using System;
using System.Collections.Generic;


namespace JobBoard.Models
{
    public class JobOpening
    {
        public string JobTitle { get; }
        

        public JobOpening(string myJobTitle)
        {
            JobTitle = myJobTitle;
        }
        
    }
}
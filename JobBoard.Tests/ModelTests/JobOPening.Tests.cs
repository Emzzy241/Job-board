using JobBoard.Models;  
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;



namespace JobBoard.Tests.ModelTests
{
    [TestClass]
    public class JobOpeningTests
    {
        
        // 1st Test: Test for constructor
       [TestMethod]
        [TestCategory("JobOpening")]
        public void JobOpening_CreatesInstanceOfJobOpening_JobOpening()
        {
             Contact contactInfo = new Contact
            {
                Name = "Mojiboye Emmanuel",
                Email = "emzzyoluwole@gmail.com",
                PhoneNumber = "+234-9012857304"
            };
            JobOpening newJob = new JobOpening("Dot Net Developer", "This is a role for the best Dot Net Developer in town.. He/She will be working with Our Team of highly technical Associates", contactInfo);

            Assert.AreEqual(typeof(JobOpening), newJob.GetType());
        }
    
        // 2nd Test: Test to get the JobTitle field from our constructor
       [TestMethod]
        [TestCategory("JobOpening")]
        public void GetJobTitle_ReturnsJobTitle_String()
        {
            // Arrange
             Contact contactInfo = new Contact
            {
                Name = "Mojiboye Emmanuel",
                Email = "emzzyoluwole@gmail.com",
                PhoneNumber = "+234-9012857304"
            };

            JobOpening newJob = new JobOpening("Dot Net Developer", "This is a role for the best Dot Net Developer in town.. He/She will be working with Our Team of highly technical Associates", contactInfo);
            string expectedjobTitle = "Dot Net Developer";

            // Act
            string returnedJobTitle = newJob.JobTitle;

            // Assert
            Assert.AreEqual(expectedjobTitle, returnedJobTitle);
        } 
    
        // 3rd Test: Test to set the JoTitle field in our constructor
       [TestMethod]
        [TestCategory("JobOpening")]
        public void SetJobTitle_SetsJobTitle_Void()
        {
            // Arrange
             Contact contactInfo = new Contact
            {
                Name = "Mojiboye Emmanuel",
                Email = "emzzyoluwole@gmail.com",
                PhoneNumber = "+234-9012857304"
            };
            JobOpening newJob = new JobOpening("Dot Net Developer", "This is a role for the best Dot Net Developer in town.. He/She will be working with Our Team of highly technical Associates", contactInfo);
            string newjobTitle = "C# and Unit Testing Developer";

            // Act
            newJob.JobTitle = newjobTitle;

            // Assert
            Assert.AreEqual(newjobTitle, newJob.JobTitle);
        } 
    
         // 4th Test: Test to get the JobDescription field from our constructor
       [TestMethod]
        [TestCategory("JobOpening")]
        public void GetJobDescription_ReturnsJobDescription_String()
        {
            // Arrange
             Contact contactInfo = new Contact
            {
                Name = "Mojiboye Emmanuel",
                Email = "emzzyoluwole@gmail.com",
                PhoneNumber = "+234-9012857304"
            };
            
            JobOpening newJob = new JobOpening("Dot Net Developer", "This is a role for the best Dot Net Developer in town.. He/She will be working with Our Team of highly technical Associates", contactInfo);
            string expectedjobDescription = "This is a role for the best Dot Net Developer in town.. He/She will be working with Our Team of highly technical Associates";

            // Act
            string returnedJobDescription = newJob.JobDescription;

            // Assert
            Assert.AreEqual(expectedjobDescription, returnedJobDescription);
        } 

        // 5th Test: Test to set the JoDescription field in our constructor
       [TestMethod]
        [TestCategory("JobOpening")]
        public void SetJobDescription_SetsJobDescription_Void()
        {
            // Arrange
            Contact contactInfo = new Contact
            {
                Name = "Mojiboye Emmanuel",
                Email = "emzzyoluwole@gmail.com",
                PhoneNumber = "+234-9012857304"
            };

            // Act
            JobOpening newJob = new JobOpening("Dot Net Developer", "This is a role for the best Dot Net Developer in town.. He/She will be working with Our Team of highly technical Associates", contactInfo);
            string newjobDescription = "Our Company CDS[codeDynasty Studios] need a C# and Unit Testing Developer";

            newJob.JobDescription = newjobDescription;

            // Assert
            Assert.AreEqual(newjobDescription, newJob.JobDescription);
        } 

        
        // 6th Test: I made an object(contactInfo) a property to another object(JobOpening)... Writing a Test to see if it worked
        [TestMethod]
        [TestCategory("JobOpening")]
        public void JobOpeningConstructor_ShouldInitializeProperties_Object()
        {
            // Arrange
            Contact contactInfo = new Contact
            {
                Name = "Mojiboye Emmanuel",
                Email = "emzzyoluwole@gmail.com",
                PhoneNumber = "+234-9012857304"
            };

            // Act
            JobOpening job = new JobOpening("Software Developer", "Develop software", contactInfo);

            // Assert
            Assert.AreEqual("Software Developer", job.JobTitle);
            Assert.AreEqual("Develop software", job.JobDescription);
            Assert.AreEqual(contactInfo, job.JobContactInfo);
        }

        // 7th Test: Test to set the properties of Contact
        [TestMethod]
        [TestCategory("JobOpening")]
        public void SetPropertiesValue_SetsPropertyValueOfContact_Void()
        {
            // Arrange
             Contact contactInfo = new Contact
            {
                Name = "Mojiboye Emmanuel",
                Email = "emzzyoluwole@gmail.com",
                PhoneNumber = "+234-9012857304"
            };
            JobOpening job = new JobOpening("Software Developer", "Develop software", contactInfo);
            string newContactName = "Bisi Bolatito";
            string newContactEmail = "bisibaby@gmail.com";
            string newContactNumber = "+234-1124567777";
            // Act
            job.JobContactInfo.Name = newContactName;
            job.JobContactInfo.Email = newContactEmail;
            job.JobContactInfo.PhoneNumber = newContactNumber;

            // Assert
            Assert.AreEqual("Bisi Bolatito", job.JobContactInfo.Name);
        }


    
    
    
    }

}
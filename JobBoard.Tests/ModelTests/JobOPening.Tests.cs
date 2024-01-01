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
            JobOpening newJob = new JobOpening("Dot Net Developer", "This is a role for the best Dot Net Developer in town.. He/She will be working with Our Team of highly technical Associates");

            Assert.AreEqual(typeof(JobOpening), newJob.GetType());
        }
    
        // 2nd Test: Test to get the JobTitle field from our constructor
        [TestMethod]
        [TestCategory("JobOpening")]
        public void GetJobTitle_ReturnsJobTitle_String()
        {
            // Arrange
            JobOpening newJob = new JobOpening("Dot Net Developer", "This is a role for the best Dot Net Developer in town.. He/She will be working with Our Team of highly technical Associates");
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
            JobOpening newJob = new JobOpening("Dot Net Developer", "This is a role for the best Dot Net Developer in town.. He/She will be working with Our Team of highly technical Associates");
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
            JobOpening newJob = new JobOpening("Dot Net Developer", "This is a role for the best Dot Net Developer in town.. He/She will be working with Our Team of highly technical Associates");
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
            JobOpening newJob = new JobOpening("Dot Net Developer", "This is a role for the best Dot Net Developer in town.. He/She will be working with Our Team of highly technical Associates");
            string newjobDescription = "Our Company CDS[codeDynasty Studios] need a C# and Unit Testing Developer";

            // Act
            newJob.JobDescription = newjobDescription;

            // Assert
            Assert.AreEqual(newjobDescription, newJob.JobDescription);
        } 
    
         [TestMethod]
        [TestCategory("JobOpening")]
        public void GetJobContactInfo_ReturnsJobContactInfo_Object()
        {
            // Arrange
            JobOpening newJob = new JobOpening("Dot Net Developer", "This is a role for the best Dot Net Developer in town.. He/She will be working with Our Team of highly technical Associates");
            string expectedjobContactInfo = "This is a role for the best Dot Net Developer in town.. He/She will be working with Our Team of highly technical Associates";

            // Act
            string returnedJobContactInfo = newJob.JobContactInfo;

            // Assert
            Assert.AreEqual(expectedjobContactInfo, returnedJobContactInfo);
        } 
    
    
    
    }

}
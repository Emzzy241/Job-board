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
        public void JobOpening_CreatesInstanceOfJobOpening_JobOpening()
        {
            JobOpening newJob = new JobOpening("Dot Net Developer");

            Assert.AreEqual(typeof(JobOpening), newJob.GetType());
        }
    
        // 2nd Test: Test to get the JobTitle field from our constructor
        [TestMethod]
        public void GetJobTitle_ReturnsJobTitle_String()
        {
            // Arrange
            JobOpening newJob = new JobOpening("Dot Net Developer");
            string expectedjobTitle = "Dot Net Developer";

            // Act
            string returnedJobTitle = newJob.JobTitle;

            // Assert
            Assert.AreEqual(expectedjobTitle, returnedJobTitle);
        } 
    
        // 3rd Test: Test to set the JobTitle field in our constructor
        // [TestMethod]
        // public void SetJobTitle_SetsJobTitle_Void()
        // {
        //     // Arrange
        //     JobOpening newJob = new JobOpening("Dot Net Developer");
        //     string newjobTitle = "C# and Unit Testing Developer";

        //     // Act
        //     newJob.JobTitle = newjobTitle;

        //     // Assert
        //     Assert.AreEqual(newjobTitle, newJob.JobTitle);
        // } 
    
    
    
    
    
    
    
    }

}
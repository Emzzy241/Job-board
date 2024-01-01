// using JobBoard.Models;  
// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System;
// using System.Collections.Generic;



// namespace JobBoard.Tests.ModelTests
// {
//     [TestClass]
//     public class ContactTests 
//     {
//         // 1st Test: Test for constructor
//         [TestMethod]
//         [TestCategory("Contact")]
//         public void Contact_CreatesInstanceOfContact_Contact()
//         {
//             Contact newJob = new Contact();

//             Assert.AreEqual(typeof(Contact), newJob.GetType());
//         }
    
//         // 2nd Test: Test to get the JobTitle field from our constructor
//         [TestMethod]
//         [TestCategory("Contact")]
//         public void GetContactName_ReturnsContactName_String()
//         {
//             // Arrange
//             Contact newJob = new Contact("Dot Net Developer", "This is a role for the best Dot Net Developer in town.. He/She will be working with Our Team of highly technical Associates", "Mojiboye Emmanuel");
//             string expectedContactName = "Dot Net Developer";

//             // Act
//             string returnedContactName = newJob.ContactName;

//             // Assert
//             Assert.AreEqual(expectedContactName, returnedContactName);
//         } 
//     /* 
//         // 3rd Test: Test to set the JoTitle field in our constructor
//         [TestMethod]
//         public void SetJobTitle_SetsJobTitle_Void()
//         {
//             // Arrange
//             Contact newJob = new Contact("Dot Net Developer", "This is a role for the best Dot Net Developer in town.. He/She will be working with Our Team of highly technical Associates");
//             string newjobTitle = "C# and Unit Testing Developer";

//             // Act
//             newJob.JobTitle = newjobTitle;

//             // Assert
//             Assert.AreEqual(newjobTitle, newJob.JobTitle);
//         } 
    
//          // 4th Test: Test to get the JobDescription field from our constructor
//     */   
    
    
    
    
    
//     }

// }
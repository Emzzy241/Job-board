using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
    public class JobBoardController : Controller
    {
        [HttpGet("/jobboard")]
        public ActionResult Index()
        {
            List<JobOpening> myJobOpeningsList = JobOpening.GetAllJobs();
            Console.WriteLine($"Number of jobs in the list: {myJobOpeningsList.Count}");
            return View(myJobOpeningsList);
        }


        [HttpGet("/jobboard/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/jobboard")]
        public ActionResult Create(string myNewJobTitle, string myNewJobDescription, string contactsName, string contactsMail, string contactsNumber)
        {
            // Create a new Contact instance
            Contact myNewJobContactInfo = new Contact
            {
                Name = contactsName,
                Email = contactsMail,
                PhoneNumber = contactsNumber
            };

            // Create a new JobOpening using the parameters
            JobOpening newJob = new JobOpening(myNewJobTitle, myNewJobDescription, myNewJobContactInfo);

            // Pass the newly created job to the Index view
            return RedirectToAction("Index");
        }

    }
}

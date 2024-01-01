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
        public ActionResult Create(string newJobTitle, string newJobDescription, string jobPosterName, string jobPosterMail, string jobPosterNumber)
        {
            // Create a new Contact instance
            Contact myNewJobContactInfo = new Contact
            {
                Name = jobPosterName,
                Email = jobPosterMail,
                PhoneNumber = jobPosterNumber
            };

            // Create a new JobOpening using the parameters
            JobOpening newJob = new JobOpening(newJobTitle, newJobDescription, myNewJobContactInfo);

            // Pass the newly created job to the Index view
            return RedirectToAction("Index");
        }

        [HttpGet("/jobboard/{id}")]
        public ActionResult Show(int id)
        {
            JobOpening findJobOpening = JobOpening.FindJob(id);
            return View(findJobOpening);
        }

    }
}

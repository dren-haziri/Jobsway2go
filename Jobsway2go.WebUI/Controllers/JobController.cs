using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;
using Jobsway2go.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jobsway2go.WebUI.Controllers
{
    public class JobController : Controller
    {
        private readonly IJobService _JobService;

        public JobController(IJobService jobService)
        {
            _JobService = jobService;
        }
        public IActionResult Index()
        {
            var joblist = _JobService.ListJobs();
            return View(joblist);
        }
        public IActionResult Add()
        {
            var model = new JobModel();
            return View(model);
        }

        // GET: Product/Edit/5  
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Job? job = _JobService.GetById(id);
            if (job != null)
            {
                var model = new JobModel()
                {
                    Id = id,
                    Description = job.Description,
                    CompanyName = job.CompanyName!,
                    Location = job.Location!,
                    Schedule = job.Schedule,
                    OpenSpots = job.OpenSpots,
                    Requirements = job.Requirements,
                    DateFrom = job.DateFrom,
                    DateTo = job.DateTo,
                    Payment = job.Payment,
                };
                return View("Add", model);
            }

            return RedirectToAction("Index");
        }




        [HttpPost]
        public IActionResult Add(JobModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id == 0)
                {
                    var job = new Job { CompanyName = model.CompanyName, Description = model.Description, Location = model.Location, Schedule = model.Schedule, OpenSpots = model.OpenSpots, Requirements = model.Requirements, DateTo = model.DateTo, DateFrom = model.DateFrom, Payment = model.Payment };
                    _JobService.Add(job);
                    _JobService.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {

                    var postjob = _JobService.GetById(model.Id);

                    if (postjob != null)
                    {
                        postjob.CompanyName = model.CompanyName;
                        postjob.Description = model.Description;
                        postjob.Location = model.Location;
                        postjob.Schedule = model.Schedule;
                        postjob.OpenSpots = model.OpenSpots;
                        postjob.Requirements = model.Requirements;
                        postjob.DateTo = model.DateTo;
                        postjob.DateFrom = model.DateFrom;
                        postjob.Payment = model.Payment;

                        _JobService.Update(postjob);
                        _JobService.SaveChanges();

                        return RedirectToAction("Index");

                    }
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetJobsJson()
        {
            var jobs = _JobService.GetAll();
            //var jobtype = _JobService.GetAllJobTypes();

            var result = jobs.Select(x => new
            {
                Id = x.Id,
                Description = x.Description,
                CompanyName = x.CompanyName!,
                Location = x.Location!,
                Schedule = x.Schedule,
                OpenSpots = x.OpenSpots,
                Requirements = x.Requirements,
                DateFrom = x.DateFrom,
                DateTo = x.DateTo,
                Payment = x.Payment,
            });

            return new JsonResult(result);
        }
        // POST: Product/Delete/5  

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var job = _JobService.GetById(id);
                if (job != null)
                {
                    _JobService.Remove(job);
                    _JobService.SaveChanges();

                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

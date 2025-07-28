using BussinessLayer.Concrete;
using BussinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class JobController : Controller
    {
        JobManager jobManager = new JobManager(new EFJobDal());
        public IActionResult Index()
        {
            var values = jobManager.TGetList(); // bütün degerleri getirir.
            return View(values);
        }
        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddJob(Job p)
        {
            jobManager.TInsert(p);
            return View();
        }
        public IActionResult DeleteJob(int id)
        {
            var value = jobManager.TGetById(id);
            jobManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var value = jobManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateJob(Job p)
        {
            jobManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}

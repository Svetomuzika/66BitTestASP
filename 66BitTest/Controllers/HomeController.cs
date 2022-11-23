using _66BitTest.Models;
using _66BitTest.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using _66BitTest.Models.Interfaces;

namespace _66BitTest.Controllers
{
    public class HomeController : Controller
    {
        IUnitOfWork unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var teams = unitOfWork.Footballers.GetAll().Select(x => x.Team).Distinct().ToList();
            var viewModel = new FootballersViewModel { Teams = teams, Countries = Model.Countries, Sex = Model.Sex };

            return View(viewModel);
        }

        public IActionResult Footballers()
        {
            var footballers = unitOfWork.Footballers.GetAll().ToList();
            var viewModel = new FootballersViewModel {Footballers = footballers, Countries = Model.Countries};

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(FootballersViewModel viewModel)
        {
            unitOfWork.Footballers.Create(viewModel.Footballer);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(int id, FootballersViewModel viewModel)
        {
            unitOfWork.Footballers.Update(viewModel.Footballers.Where(x => x.Id == id).SingleOrDefault());

            return NoContent();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

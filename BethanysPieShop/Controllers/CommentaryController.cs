using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BethanysPieShop.ViewModels;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bageriet.Controllers
{

    [Authorize]
    public class CommentaryController : Controller
    {
        private readonly ICommentary _CommentaryRepository;
        private readonly IPieRepository _pieRepository;
        // private Commentary _Commentary;

        public CommentaryController(ICommentary CommentaryRepository, IPieRepository pieRepository)
        {
            _CommentaryRepository = CommentaryRepository;
            _pieRepository = pieRepository;
        }

        public IActionResult CommentaryD(int pieId)
        {
            Commentary newCommentary = new Commentary();
            var pie = _pieRepository.GetPieById(pieId);
            newCommentary.PieId = pie.PieId;

            newCommentary.CommentId += 1;

            if(ModelState.IsValid)
            {
                _CommentaryRepository.CreateCommentAndAddToDatabase(newCommentary);
                return View(newCommentary);
            }

            return View(newCommentary);
        }

        [HttpPost]
        public IActionResult CommentaryD(Commentary newCommentary)
        {
            newCommentary.CommentId += 1;
            // _Commentary = newCommentary;

            // Hvordan får jeg mit pieId med fra order formen?          

            if (newCommentary == null)
            {
                ModelState.AddModelError("", "Please insert Your Review is empty");
            }

            if (ModelState.IsValid)
            {
                /*
                _CommentaryRepository.CreateCommentAndAddToDatabase(newCommentary);
                return RedirectToAction("ReviewComplete");
                */

                _CommentaryRepository.CreateCommentUpdateDatabase(newCommentary);
                return RedirectToAction("ReviewComplete");
            }

            return View(newCommentary);
        }

        public IActionResult ReviewComplete()
        {
            ViewBag.ReviewCompleteMessage = "Thank you";
            return View();
        }
    }
}

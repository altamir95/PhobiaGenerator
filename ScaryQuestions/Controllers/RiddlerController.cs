using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScaryQuestions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScaryQuestions.Controllers
{
    public class ForQuestionRating
    {
        public string IdOfTheRequiredQuestion { get; set; }
        public string YesOrNo { get; set; }
    }
    public class LetterDetails
    {
       public string Email { get; set; }
        public string Subject { get; set; }
        public string Messag { get; set; }
    }
    public class RiddlerController : Controller
    {
        ScaryQuestionsContext db;
        public RiddlerController(ScaryQuestionsContext context)
        {
            db = context;
        }
        public IActionResult QuestionGenerator()
        {
            return View();
        }
        [HttpPost]
        public  string QuestionGenerator(ForQuestionRating forQuestionRating)
        {
            Question FoundQuestion =  db.Questions.FirstOrDefault(x =>x.Id== int.Parse(forQuestionRating.IdOfTheRequiredQuestion));
            if (forQuestionRating.YesOrNo == "yes")
            {
                FoundQuestion.LikeForQuestion +=1;
        }
            else
            {
                FoundQuestion.DislikeForQuestion += 1;
        }
        db.Update(FoundQuestion);
             db.SaveChanges();
            return "fdffd";
        }



        public IActionResult SendLetter()
        {
            return View();
        }
        [HttpPost]
        public async void SendLetter(LetterDetails letterDetails)
        {
            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync(letterDetails.Email, letterDetails.Subject, letterDetails.Messag);
        }
    }
}

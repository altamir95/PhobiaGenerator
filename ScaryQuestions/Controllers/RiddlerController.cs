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
            if (!db.Questions.Any())
            {
                db.Questions.AddAsync(new Question { TheQuestion = "что кто-то увидит как ты корчишься в лифте", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "что во сне заползет в рот паук", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "что пока ты будешь, спать телефон взорвется и  сгорит весь дом ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "оглохнуть от того что постоянно громко слушаешь музыку ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "сойти с ума и не заметить ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "стать в старости занудными пенсионером ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "выпасть с болонка от сильного ветра ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "от назойливых мыслей реально засунуть руку в мясорубку ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "что когда встретишь кумира, сядет телефон ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "сломать зубы костью во время жевания мяса ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "шутить над недостатками других, боясь что сам будешь таким ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "стать тупым как обещала училка ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "стать лунатиком и выйти на улицу в том что лег спать ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "уронить новорожденного ребенка ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "что за новогодним ужином люстра упадет тебе на голову ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "отрезать палец во время чистки картошки ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "отравится шаурмой до реанимации ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "сесть на крашеную коричневой краской скамейку ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "поехать командировкой в КНДР и случайно там застрять ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "что за репосты реально сажают и за тобой уже выехали ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "что родители установят дома скрытую камеру и узнают обо всем что ты делаешь ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "что сосед заснял тебя через открытое око и залил в сеть ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "что мастера в авто мастерской заменят все детали твоей новой машины на Б / У ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "что люди смеются над твоими шутами только из жалости ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "что остановит полицейский и как в фильмах подкинет травку ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "что мама не шутила про волчонка людоеда ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "один день все пойдет ко дну и ты станешь бездомным алкоголиком ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "что когда выйдешь с общественного туалета все подумают что этот ужас оставил ты ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "выйти вынести мусор в чем попало и встретить старого одноклассника ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "что на самом деле не окружающие тупые а ты ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "что на тебя упадет стеллаж с посудой твоей прапрабабушки ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "когда будешь закручивать лампочку упадешь насмерть со стремянки ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "корректоры в знак наказания засунут тебя в стиральную машину ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "вместо айфона продадут чайнафон ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = " порезаться листом", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "что залетит в машину пчела от чего потеряешь управление и вмажешься в столб насмерть ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "выпить вместо воды крепкий уксус и обжечь желудок ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.Questions.AddAsync(new Question { TheQuestion = "открыть сильно дверь и сломать кому-то нос ", LikeForQuestion = 0, DislikeForQuestion = 0 });
                db.SaveChanges();
            }
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
            return "ok";
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

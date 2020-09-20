using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScaryQuestions.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string TheQuestion { get; set; }
        public int LikeForQuestion { get; set; }
        public int DislikeForQuestion { get; set; }
    }
}

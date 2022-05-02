using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Question
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string Question1 { get; set; }
        public string CorrectAnswer { get; set; }
        public string InCorrectAnswer1 { get; set; }
        public string InCorrectAnswer2 { get; set; }
        public string InCorrectAnswer3 { get; set; }
        public string Author { get; set; }
    }
}

using System.Collections.Generic;

namespace API.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Prompt { get; set; }
        public string AdditionalInfo { get; set; }
        public string ApplicantAnswer { get; set; }
        public string ApplicantNotes { get; set; }
        public List<AnswerOption> AssessorScore { get; set; } = new List<AnswerOption>();
        public string AssessorNotes { get; set; }
    }
}

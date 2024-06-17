namespace API.Entities
{
    public class Questionnaire
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
        public Assessment Assessment { get; set; }
        public int AssessmentId { get; set; }
    }
}
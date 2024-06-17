namespace API.Entities
{
    public class AnswerOption
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public AnswerOptionType Type { get; set; }
    }

    public enum AnswerOptionType
    {
        Compliant,
        MajorNonCompliance,
        AutomaticFailure,
        MoreInformationRequired
    }
}

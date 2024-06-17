namespace API.Entities
{
    public class Sample
    {
        public int Id { get; set; }
        public string SampleName { get; set; }
        public SampleType SampleType { get; set; }
        public int Quantity { get; set; }
    }

    public enum SampleType
    {
        ExternalIP,
        Server,
        Workstation,
        Mobile
    }
}
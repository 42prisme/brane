namespace brane.Models
{
    public class ExigenceItem
    {
        enum Exigence_Type {
            BDD,
            IHM,
            PERF
        }

        public int Id { get; set; }
        public string Label { get; set; }
        public JalonItem Jalon { get; set; }
    }
}
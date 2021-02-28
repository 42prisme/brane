namespace brane.Models
{
    public class ExigenceItem
    {
        enum Exigence_Type {
            BDD,
            IHM,
            PERF
        }
        public string m_label;
        public JalonItem m_jalon;
    }
}
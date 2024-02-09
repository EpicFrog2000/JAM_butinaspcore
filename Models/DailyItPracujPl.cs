namespace APP1.Models
{
    public class DailyItPracujPl
    {
        public class daily_data
        {
            public int? id { get; set; }
            public string? company { get; set; }
            public string? title { get; set; }
            public string? location { get; set; }
            public int? salary { get; set; }
            public int? doswiadczenie { get; set; }
            public DateTime? date { get; set; }
        }
        public class daily_etat
        {
            public int? id { get; set; }
            public string? etat { get; set; }
        }
        public class daily_kontrakt
        {
            public int? id { get; set; }
            public string? kontrakt { get; set; }
        }
        public class daily_management_level
        {
            public int? id { get; set; }
            public string? management_level { get; set; }
        }
        public class daily_specjalizacje
        {
            public int? id { get; set; }
            public string? specjalizacja { get; set; }
        }
        public class daily_technologie_mile_widziane
        {
            public int? id { get; set; }
            public string? technologia { get; set; }
        }
        public class daily_technologie_wymagane
        {
            public int? id { get; set; }
            public string? technologia { get; set; }
        }
        public class daily_work_type
        {
            public int? id { get; set; }
            public string? work_type { get; set; }
        }
    }

}

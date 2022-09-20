using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brandanalytics.Models
{
    public class SearchTerm
    {
        public string Id { get; set; } = null!;
        public string? Department { get; set; }
        public string? searchTerm { get; set; }
        public string? SearchFrequencyRank { get; set; }
        public string? ClickedAsins1 { get; set; }
        public string? ProductTitle1 { get; set; }
        public string? ClickRate1 { get; set; }
        public string? TurnoverRate1 { get; set; }
        public string? ClickedAsins2 { get; set; }
        public string? ProductTitle2 { get; set; }
        public string? ClickRate2 { get; set; }
        public string? TurnoverRate2 { get; set; }
        public string? ClickedAsins3 { get; set; }
        public string? ProductTitle3 { get; set; }
        public string? ClickRate3 { get; set; }
        public string? TurnoverRate3 { get; set; }
    }
}

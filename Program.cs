using brandanalytics.Data;
using brandanalytics.Models;
using System.Text;

namespace brandanalytics
{
    class Program
    {
        private static readonly BrandAnalyticsDbContext _context =
            new BrandAnalyticsDbContext();
        static void Main(string[] args)
        {
            _context.Database.EnsureCreated();
            using (StreamReader sr = new StreamReader("D:/Web  Rss Feed  Email Scraper (4).csv"))
            {
                string currentLine;
                int i = 0;
                // currentLine will be null when the StreamReader reaches the end of file
                while ((currentLine = sr.ReadLine()) != null)
                {
                    if(i > 1)
                    {
                        SearchTerm searchTerm = new SearchTerm();
                        var values = currentLine.Split(',');
                        searchTerm.Id = Guid.NewGuid().ToString("N");
                        searchTerm.Department = values[0];
                        searchTerm.searchTerm = Encoding.GetEncoding(1252).GetString(Encoding.UTF8.GetBytes(values[1]));
                        searchTerm.SearchFrequencyRank = values[2];
                        searchTerm.ClickedAsins1 = Encoding.GetEncoding(1252).GetString(Encoding.UTF8.GetBytes(values[3]));
                        searchTerm.ProductTitle1 = Encoding.GetEncoding(1252).GetString(Encoding.UTF8.GetBytes(values[4]));
                        searchTerm.ClickRate1 = Encoding.GetEncoding(1252).GetString(Encoding.UTF8.GetBytes(values[5]));
                        searchTerm.TurnoverRate1 = Encoding.GetEncoding(1252).GetString(Encoding.UTF8.GetBytes(values[6]));
                        searchTerm.ClickedAsins2 = Encoding.GetEncoding(1252).GetString(Encoding.UTF8.GetBytes(values[7]));
                        searchTerm.ProductTitle2 = Encoding.GetEncoding(1252).GetString(Encoding.UTF8.GetBytes(values[8]));
                        searchTerm.ClickRate2 = Encoding.GetEncoding(1252).GetString(Encoding.UTF8.GetBytes(values[9]));
                        searchTerm.TurnoverRate2 = Encoding.GetEncoding(1252).GetString(Encoding.UTF8.GetBytes(values[10]));
                        searchTerm.ClickedAsins3 = Encoding.GetEncoding(1252).GetString(Encoding.UTF8.GetBytes(values[11]));
                        searchTerm.ProductTitle3 = Encoding.GetEncoding(1252).GetString(Encoding.UTF8.GetBytes(values[12]));
                        searchTerm.ClickRate3 = Encoding.GetEncoding(1252).GetString(Encoding.UTF8.GetBytes(values[13]));
                        searchTerm.TurnoverRate3 = Encoding.GetEncoding(1252).GetString(Encoding.UTF8.GetBytes(values[14]));

                        _context.SearchTerms.AddAsync(searchTerm);
                        _context.SaveChanges();
                    }
                    Console.WriteLine(i);
                    i++;
                }
            }

        }
    }
}
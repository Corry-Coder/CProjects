using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsSurvey
{
    public class Survey
    {
        public int SurveyId { get; set; }
        public string Name { get; set; }
        public string Basketball { get; set; }
        public string Football { get; set; }
    }
    public class SurveyContext : DbContext
    {
        public SurveyContext() : base("SurveyContext")
        {
        }

        public DbSet<Survey> Teams { get; set; }
    }
}

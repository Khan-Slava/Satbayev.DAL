using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.DAL
{
    public class QuestionTemplate
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Author { get; set; }
        public string Questions { get; set; }
        public double Mark { get; set; }
        public string Level { get; set; }
        public string ChangeAuthor { get; set; }
        public DateTime ChangeData { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }

    }

}

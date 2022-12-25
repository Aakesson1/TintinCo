using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TintinCo_.Model
{
    public class Comic
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public string Request { get; set; }
        public int ReleaseYear { get; set; }
        public string QualityColor { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int TitleID { get; set; }
    }
}

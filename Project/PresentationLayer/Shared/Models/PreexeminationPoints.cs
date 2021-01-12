using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
   public class PreexeminationPoints
    {
        public int Id { get; set; }
        public int Colloquium { get; set; }
        public int SeminaryWork { get; set; }
        public int Homework { get; set; }
        public int Activity { get; set; }
    }
}

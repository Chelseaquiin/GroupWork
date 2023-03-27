using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupWork.Models
{
    public class Grade
    {
        public int ID { get; set; }
        public string GradeName { get; set; }

        public List<Students> Students { get; set; }

       
    }
}

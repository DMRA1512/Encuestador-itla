using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class Answers
    { 
        


        public List<repos2> Encuestas = new List<repos2>();

        public List<reposanswer> Preguntas = new List<reposanswer>();
        
        
        public static Answers instancia { get; set; } = new Answers();

    }
}

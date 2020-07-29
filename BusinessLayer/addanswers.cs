using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class addanswers
    {

        public void add2 (repos2 item)
        {

            Answers.instancia.Encuestas.Add(item);
           

        }
        public void editar (repos2 item, int index)
        {

            Answers.instancia.Encuestas[index] = item;
            


        }
        public void borrar (int index)
        {
            Answers.instancia.Encuestas.RemoveAt(index);
          




        }
       public List<repos2> Getall()
        {
            return Answers.instancia.Encuestas;
            

        }
       
    }
}

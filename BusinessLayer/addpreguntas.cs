using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class addpreguntas
    {
        public void add2(reposanswer item)
        {

            Answers.instancia.Preguntas.Add(item);


        }
        public void editar(reposanswer item, int index)
        {

            Answers.instancia.Preguntas[index] = item;



        }
        public void borrar(int index)
        {
            Answers.instancia.Preguntas.RemoveAt(index);





        }
        public List<reposanswer> Getall()
        {
            return Answers.instancia.Preguntas;


        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace EncuestadorITLA
{
    
    
    public partial class Nueva_Encuesta : Form
    {
        public int? edit;
        Encuesta encuesta;


        public Nueva_Encuesta()
        {
            encuesta =  new Encuesta();

            InitializeComponent();
        }

        public void Nueva_Encuesta_Load(object sender, EventArgs e)
        {

        }

        public void cb_numeroP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        public void btn_Continuar_Click(object sender, EventArgs e)
        {
            add();


            
         
           
            Preguntas newform = new Preguntas();
            newform.Show();

           
            

            



        }
        public void add()
        {
            addanswers ADDANSWER = new addanswers();

            repos2 repos2 = new repos2();
            

            repos2.Encuesta = tb_Nencuesta.Text;
            repos2.N_Preguntas = tb_npreguntas.Text;


            if (edit != null)
            {


            }
            else
            {

                ADDANSWER.add2(repos2);

                encuesta.loadData();
                cleardata();

            }


        }

        private void tb_Nencuesta_TextChanged(object sender, EventArgs e)
        {

        }
        public void cleardata()
        {
            tb_Nencuesta.Clear();
            tb_npreguntas.Clear();


        }
    }
}

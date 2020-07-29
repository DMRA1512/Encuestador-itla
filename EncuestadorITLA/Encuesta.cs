using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Data.Sql;

namespace EncuestadorITLA
{
    public partial class Encuesta : Form
    {
       public addanswers Aanswers;
        SqlConnection SC;
        private int index;

        public Encuesta()
        {
            Aanswers = new addanswers();
            InitializeComponent();
        }

        private void Encuesta_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_crearencuesta_Click(object sender, EventArgs e)
        {
            Nueva_Encuesta newform = new Nueva_Encuesta();
            newform.Show();
            this.Hide();

        }

        private void dgv_encuesta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            
        }
        public void loadData()
        {
            BindingSource bindingSource = new BindingSource();


            bindingSource.DataSource = Aanswers.Getall();
            dgv_encuesta.DataSource = bindingSource;

            dgv_encuesta.ClearSelection();


        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            var update = dgv_encuesta.SelectedRows;

            if (update != null)
            {
                MessageBox.Show("Selecciona una encuesta");
            }
            else
            {
                Nueva_Encuesta newform = new Nueva_Encuesta();
                newform.Show();
                this.Hide();
                

            }
        }

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }


        private void aplicarEncuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int numeroencuesta;

            numeroencuesta = random.Next(1, 1000);

            SC = new SqlConnection("Data Source=LATITUDE\\SQLEXPRESS; initial Catalog=Registro;integrated security = true");
            SC.Open();

            string add = " INSERT INTO nuevaencuesta (numeroencuesta,nombre,numeropreguntas) VALUES( @numeroencuesta,@nombre,@numeropreguntas)";

            foreach (DataGridViewRow row in dgv_encuesta.Rows)
            { 

                SqlCommand Comand = new SqlCommand(add, SC);
                Comand.Parameters.AddWithValue("@numeroencuesta", numeroencuesta);
                Comand.Parameters.AddWithValue("@nombre", Convert.ToString(row.Cells["column0"].Value));
                Comand.Parameters.AddWithValue("@numeropreguntas", Convert.ToString(row.Cells["column1"].Value));
                Comand.ExecuteNonQuery();
                }




        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if( index < 0)
            {
                MessageBox.Show("Selecciona una encuesta");

            }
            else
            {

                Aanswers.borrar(index);
                loadData();


            }
        }
    }
}

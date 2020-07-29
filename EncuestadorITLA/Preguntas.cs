using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncuestadorITLA
{
    public partial class Preguntas : Form
    {

        private int index;
        addpreguntas addpreguntas;
        public Preguntas()
        {
            index = -1;
            addpreguntas = new addpreguntas();
            InitializeComponent();
        }

        private void Preguntas_Load(object sender, EventArgs e)
        {
            loadData();
        }
        #region Event
        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            Encuesta nueva = new Encuesta();
            nueva.Show();
            this.Hide();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                add();

            }
            else
            {
                edit();

            }

        }
        private void btn_deselect_Click(object sender, EventArgs e)
        {
            deselect();
        }

        #endregion

        public void loadData()
        {
            BindingSource bindingSource = new BindingSource();

            bindingSource.DataSource = addpreguntas.Getall();
            dgv_preguntas.DataSource = bindingSource;
            dgv_preguntas.ClearSelection();


           
        }

        
        private void deselect()
        {
            dgv_preguntas.ClearSelection();
            index = -1;
            
            limpiar();
           
        }
        private void add()
        {
            reposanswer reposanswer = new reposanswer();
            reposanswer.pregunta = tb_preguntas.Text;

            addpreguntas.add2(reposanswer);
           
            loadData();
            limpiar();
        }
        private void edit()
        {
           
                reposanswer reposanswer = new reposanswer();
                reposanswer.pregunta = tb_preguntas.Text;

                addpreguntas.editar(reposanswer,index);

                loadData();
                limpiar();
                deselect();
       }
        private void delete()
        {
            if (index < 0)
            {
                MessageBox.Show("Selecciona una pregunta");
            }
            else
            {

                addpreguntas.borrar(index);
                loadData();
                limpiar();
                deselect();

            }


        }

        private void dgv_preguntas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
                tb_preguntas.Text = dgv_preguntas.Rows[index].Cells[0].Value.ToString();            
               
               
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Encuesta encuesta = new Encuesta();
            encuesta.Show();
            this.Close();
        }

       
        private void limpiar()
        {
            tb_preguntas.Clear();


        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            delete();
        }
    }
        

        

       
    }


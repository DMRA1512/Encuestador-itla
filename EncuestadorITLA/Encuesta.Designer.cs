namespace EncuestadorITLA
{
    partial class Encuesta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_encuesta = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarEncuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicarEncuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_crearencuesta = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_encuesta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_encuesta
            // 
            this.dgv_encuesta.AllowUserToAddRows = false;
            this.dgv_encuesta.AllowUserToDeleteRows = false;
            this.dgv_encuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_encuesta.Location = new System.Drawing.Point(201, 72);
            this.dgv_encuesta.Name = "dgv_encuesta";
            this.dgv_encuesta.ReadOnly = true;
            this.dgv_encuesta.Size = new System.Drawing.Size(340, 267);
            this.dgv_encuesta.TabIndex = 4;
            this.dgv_encuesta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_encuesta_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarEncuestaToolStripMenuItem,
            this.aplicarEncuestaToolStripMenuItem,
            this.cerrarSessionToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // visualizarEncuestaToolStripMenuItem
            // 
            this.visualizarEncuestaToolStripMenuItem.Name = "visualizarEncuestaToolStripMenuItem";
            this.visualizarEncuestaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualizarEncuestaToolStripMenuItem.Text = "Visualizar encuesta";
            // 
            // aplicarEncuestaToolStripMenuItem
            // 
            this.aplicarEncuestaToolStripMenuItem.Name = "aplicarEncuestaToolStripMenuItem";
            this.aplicarEncuestaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aplicarEncuestaToolStripMenuItem.Text = "Aplicar encuesta";
            this.aplicarEncuestaToolStripMenuItem.Click += new System.EventHandler(this.aplicarEncuestaToolStripMenuItem_Click);
            // 
            // cerrarSessionToolStripMenuItem
            // 
            this.cerrarSessionToolStripMenuItem.Name = "cerrarSessionToolStripMenuItem";
            this.cerrarSessionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSessionToolStripMenuItem.Text = "Cerrar session";
            this.cerrarSessionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSessionToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.43411F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.56589F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tableLayoutPanel1.Controls.Add(this.btn_editar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_encuesta, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_crearencuesta, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_borrar, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.17544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.82456F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(749, 342);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(3, 3);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(126, 46);
            this.btn_editar.TabIndex = 7;
            this.btn_editar.Text = "Editar Encuesta";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_crearencuesta
            // 
            this.btn_crearencuesta.Location = new System.Drawing.Point(201, 3);
            this.btn_crearencuesta.Name = "btn_crearencuesta";
            this.btn_crearencuesta.Size = new System.Drawing.Size(159, 46);
            this.btn_crearencuesta.TabIndex = 5;
            this.btn_crearencuesta.Text = "Crear Encuesta";
            this.btn_crearencuesta.UseVisualStyleBackColor = true;
            this.btn_crearencuesta.Click += new System.EventHandler(this.btn_crearencuesta_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(547, 3);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(152, 46);
            this.btn_borrar.TabIndex = 6;
            this.btn_borrar.Text = "borrar encuesta";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // Encuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Encuesta";
            this.Text = "Encuesta";
            this.Load += new System.EventHandler(this.Encuesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_encuesta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_encuesta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarEncuestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicarEncuestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSessionToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_crearencuesta;
        private System.Windows.Forms.Button btn_borrar;
    }
}
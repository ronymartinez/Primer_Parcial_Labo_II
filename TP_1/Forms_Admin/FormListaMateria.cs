using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1
{
    public partial class form_listaMaterias : Form
    {
        public form_listaMaterias()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void SizeAllRows(Object sender,
        EventArgs e)
        {
            dgv_listaMateria.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void FormListaMateria_Load(object sender, EventArgs e)
        {
            dgv_listaMateria.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;      

            foreach (var item in ListaMaterias.GetListaMateriaTotales)
            {
                int n = dgv_listaMateria.Rows.Add();

                dgv_listaMateria.Rows[n].Cells[0].Value = item.NombreMateria;
                dgv_listaMateria.Rows[n].Cells[1].Value = item.MostrarProfesores();
                dgv_listaMateria.Rows[n].Cells[2].Value = item.MostrarAlumnos();
                dgv_listaMateria.Rows[n].Cells[3].Value = item.Cuatrimestre;
                dgv_listaMateria.Rows[n].Cells[4].Value = item.MostrarCorrelativas();
                dgv_listaMateria.Rows[n].Cells[5].Value = "Tecnicatura en Programación";
                dgv_listaMateria.Rows[n].Cells[6].Value = "2022";

                n++;
            }

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

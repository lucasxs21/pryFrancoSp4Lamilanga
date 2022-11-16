using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFrancoSp4Lamilanga
{
    public partial class FrmMain : Form
    {      
        public int[,] matDatos = new int[5, 4];
        public int[] VecDatos = new int[10];
        

        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_load(object sender, EventArgs e)
        {


            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void FrmMain_Load_1(object sender, EventArgs e)
        {
            //Asigno las filas y los nombre de mozos

            dgvInfo.Rows.Add("Julio");
            dgvInfo.Rows.Add("Esteban");
            dgvInfo.Rows.Add("Javier");
            dgvInfo.Rows.Add("gonzalo");
            dgvInfo.Rows.Add("Alberto");
            //desabilito edicion 
            dgvInfo.Columns[0].ReadOnly = true;
        }

        private void dgvInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int i = 0;
            int f = 0;
            int c = 1; 
            int cmat = 0;
            while (f <= 4)
            {
                while (c <= 4)
                {
                    
                    if (dgvInfo.Rows[f].Cells[c].Value == null || dgvInfo.Rows[f].Cells[c].Value == "")
                    {
                        i++;
                    }
                    c++;
                }
                c = 1;
                f++;
            }

            if (i == 0)
            {
                
                btnMozo.Enabled = true;
                btnTotal.Enabled = true;
               
                f = 0;
                c = 1;
                
                while (f <= 4)
                {
                    while (c <= 4 && cmat <= matDatos.GetLength(1))
                    {
                        matDatos[f, cmat] = Convert.ToInt32(dgvInfo.Rows[f].Cells[c].Value);
                        c++;
                        cmat++;
                    }
                    c = 1;
                    cmat = 0;
                    f++;
                }
            }
            else
            {
                
                btnMozo.Enabled = false;
                btnTotal.Enabled = false;
                MessageBox.Show("Asegurese de ingresar valores numéricos.", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnMozo_Click(object sender, EventArgs e)
        {
            int c = 0;
            int f = 0;
            int Suma = 0;
            int Mayor = 0;
            int Posicion = 0; 
            while (f < matDatos.GetLength(0))
            {
                while (c < matDatos.GetLength(1))
                {
                    Suma = Suma + matDatos[f, c];
                    c++;
                }
                VecDatos[f] = Suma;
                c = 0;
                f++;
                Suma = 0;
            }

            f = 0;
            Mayor = VecDatos[0];
            while (f <= 4)
            {
                if (VecDatos[f] >= Mayor)
                {
                    Mayor = VecDatos[f];
                    Posicion = f;
                }
                f++;
            }

            if (Posicion == 0)
            {
                txtMozo.Text = "Julio";
                txtImporteMozo.Text = Mayor.ToString();
            }
            if (Posicion == 1)
            {
                txtMozo.Text = "Esteban";
                txtImporteMozo.Text = Mayor.ToString();
            }
            if (Posicion == 2)
            {
                txtMozo.Text = "Javier";
                txtImporteMozo.Text = Mayor.ToString();
            }
            if (Posicion == 3)
            {
                txtMozo.Text = "Gonzalo";
                txtImporteMozo.Text = Mayor.ToString();
            }
            if (Posicion == 4)
            {
                txtMozo.Text = "Alberto";
                txtImporteMozo.Text = Mayor.ToString();
            }

            
                
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int f = 0;
            int c = 0;
            int i = 5;
            int Suma = 0;
            int Total = 0;

            while (c < matDatos.GetLength(1) && i <= 9)
            {
                Suma = 0;
                while (f < matDatos.GetLength(0))
                {
                    Suma = Suma + matDatos[f, c];
                    f++;
                }
                VecDatos[i] = Suma;
                Total = Total + Suma;
                f = 0;
                c++;
                i++;
            }

            VecDatos[9] = Total;

            txtComida.Text = Convert.ToString(VecDatos[5]);
            txtBebidaSin.Text = Convert.ToString(VecDatos[6]);
            txtBebidaCon.Text = Convert.ToString(VecDatos[7]);
            txtPostre.Text = Convert.ToString(VecDatos[8]);
            txtTotal.Text = Convert.ToString(VecDatos[9]);
        }

       

        

        
    }
}

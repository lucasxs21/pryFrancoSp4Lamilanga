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
            int varBandera = 0;
            int f = 0;
            int c = 1; 
            int cmat = 0;
            while (f <= 4)
            {
                while (c <= 4)
                {
                    
                    if (dgvInfo.Rows[f].Cells[c].Value == null || dgvInfo.Rows[f].Cells[c].Value == "")
                    {
                        varBandera++;
                    }
                    c++;
                }
                c = 1;
                f++;
            }

            if (varBandera == 0)
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
                MessageBox.Show("Asegurese de ingresar valores numéricos desde cero incluido en adelante.", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnMozo_Click(object sender, EventArgs e)
        {
            int c = 0;
            int f = 0;
            int varSuma = 0;
            int varMayor = 0;
            int varPosicion = 0; //capturo la posicion del mayor valor para identificar al mozo correspondiente.
            while (f < matDatos.GetLength(0))
            {
                while (c < matDatos.GetLength(1))
                {
                    varSuma = varSuma + matDatos[f, c];
                    c++;
                }
                VecDatos[f] = varSuma;
                c = 0;
                f++;
                varSuma = 0;
            }

            f = 0;
            varMayor = VecDatos[0];
            while (f <= 4)
            {
                if (VecDatos[f] >= varMayor)
                {
                    varMayor = VecDatos[f];
                    varPosicion = f;
                }
                f++;
            }

            switch (varPosicion)
            {
                case 0:
                    txtMozo.Text = "Julio";
                    txtImporteMozo.Text =varMayor.ToString();
                    break;
                case 1:
                    txtMozo.Text = "Esteban";
                    txtImporteMozo.Text = varMayor.ToString();
                    break;
                case 2:
                    txtMozo.Text = "Javier";
                    txtImporteMozo.Text = varMayor.ToString();
                    break;
                case 3:
                    txtMozo.Text = "Gonzalo";
                    txtImporteMozo.Text = varMayor.ToString();
                    break;
                case 4:
                    txtMozo.Text = "Alberto";
                    txtImporteMozo.Text = varMayor.ToString();
                    break;
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int f = 0;
            int c = 0;
            int i = 5;
            int varSuma = 0;
            int varTotal = 0;

            while (c < matDatos.GetLength(1) && i <= 9)
            {
                varSuma = 0;
                while (f < matDatos.GetLength(0))
                {
                    varSuma = varSuma + matDatos[f, c];
                    f++;
                }
                VecDatos[i] = varSuma;
                varTotal = varTotal + varSuma;
                f = 0;
                c++;
                i++;
            }

            VecDatos[9] = varTotal;

            txtComida.Text = Convert.ToString(VecDatos[5]);
            txtBebidaSin.Text = Convert.ToString(VecDatos[6]);
            txtBebidaCon.Text = Convert.ToString(VecDatos[7]);
            txtPostre.Text = Convert.ToString(VecDatos[8]);
            txtTotal.Text = Convert.ToString(VecDatos[9]);
        }

       

        

        
    }
}

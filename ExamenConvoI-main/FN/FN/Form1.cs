using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlujoNeto
{
    public partial class FrmMain : Form
    {
        string[] rows = { "Inversion", "Ingreso", "Egreso", "Depreciacion",
                        "V.S", "UAI", "IR", "UDI", "Depreciacion", "FNE" };
        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //datos
            decimal ingresos = decimal.Parse(txtIngresos.Text);
            decimal inversion = decimal.Parse(txtInversion.Text);
            int plazo = int.Parse(txtPlazo.Text);
            decimal tasa = decimal.Parse(txtTasa.Text);
            decimal inflacion = decimal.Parse(txtInflacion.Text);
            decimal ValSalv = decimal.Parse(txtValSalv.Text);
                        
            //columnas
            dgvTabla.Columns.Add("", "Años");
            for(int i = 0; i <= plazo; i++)
            {
                dgvTabla.Columns.Add("", i.ToString());
            }

            //filas
            for (int i = 0; i < rows.Length; i++)
            {
                dgvTabla.Rows.Add(rows[i]);
            }

            dgvTabla.Rows[0].Cells[1].Value = inversion;
            for(int i = 2; i < dgvTabla.ColumnCount; i++)
            {
                if(i == 2)
                {
                    dgvTabla.Rows[1].Cells[i].Value = ingresos;
                }
                else
                {
                    ingresos = ingresos + (ingresos * inflacion);
                    dgvTabla.Rows[1].Cells[i].Value = ingresos;
                }
                
            }
            














        }
        
    }
}

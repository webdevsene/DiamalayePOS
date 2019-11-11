using DiamalayPOS.Screens.ProductF;
using DiamalayPOS.Screens.OperationsF;
using DiamalayPOS.Screens.GVentesF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiamalayPOS.Screens
{
    public partial class DashboardForm : MetroFramework.Forms.MetroForm
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void MetroButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            ProductsForm pdf = new ProductsForm();
            pdf.Show();
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {

            //  a l'avenir il faut nommer les nommer 
            SalesOperationsForm sop = new SalesOperationsForm();
            sop.Show();
        }

        private void BtnRapportVentes_Click(object sender, EventArgs e)
        {
            GVentesF.OperationsManagerScreen gv = new Screens.GVentesF.OperationsManagerScreen();
            gv.Show();
        }
    }
}

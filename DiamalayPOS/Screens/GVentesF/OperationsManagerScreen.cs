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
using DiamalayPOS.General;

namespace DiamalayPOS.Screens.GVentesF
{
    public partial class OperationsManagerScreen : MetroFramework.Forms.MetroForm
    {
        public OperationsManagerScreen()
        {
            /*this.StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StyleManager.Style = MetroFramework.MetroColorStyle.Green;*/
            InitializeComponent();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OperationsManagerScreen_Load(object sender, EventArgs e)
        {
            // when you load this screen I want display any record in table [tblOperations]
            // in the datagridViewrpt

            //connexion a la bd
            using (SqlConnection con = new SqlConnection(ApplicationSettings.connectionString()))
            {
                try
                {
                    con.Open();

                    //TODO Something as sql commande to display any rows in dtgv
                    /* using (SqlDataAdapter da = new SqlDataAdapter("usp_SELECT_AllOpearationData", con))
                     {

                         DataTable dt = new DataTable();
                         da.SelectCommand.CommandType = CommandType.StoredProcedure;
                         da.Fill(dt);

                         datagridViewrpt.DataSource = dt;

                         // ajouter une collone supprimer au datagridview
                         DataGridViewButtonColumn dtgvbtn = new DataGridViewButtonColumn();
                         dtgvbtn.HeaderText = "Supprimer";
                         dtgvbtn.Name = "supprimer";
                         datagridViewrpt.Columns.Add(dtgvbtn);
                     }*/

                    using (DataTable dt = getAllOperationByDateTime())
                    {
                        //dt = getAllOperationByDateTime();

                        datagridViewrpt.DataSource = dt;

                        // ajouter une collone supprimer au datagridview
                        DataGridViewButtonColumn dtgvbtn = new DataGridViewButtonColumn();
                        dtgvbtn.HeaderText = "Supprimer";
                        dtgvbtn.Name = "supprimer";
                        datagridViewrpt.Columns.Add(dtgvbtn);
                    }

                }
                catch (Exception)
                {

                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
            }
        }

        private void DatagridViewrpt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_rpt_exp_Click(object sender, EventArgs e)
        {

            if (datagridViewrpt.Rows.Count > 0)
            {
                // // creating Excel Application 
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);


                //storing header part in Excel retrieve +1 
                for (int i = 1; i < datagridViewrpt.Columns.Count; i++)
                {
                    xcelApp.Cells[1, i] = datagridViewrpt.Columns[i - 1].HeaderText;
                }

                // stored each row and column value in excel sheet
                for (int i = 0; i < datagridViewrpt.Rows.Count; i++)
                {
                    for (int j = 0; j < datagridViewrpt.Columns.Count - 1; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = datagridViewrpt.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // save excel sheet and show
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
            else
            {
                // si la datagridview/datatable  ne contient aucune ligne c'est qu'il n' y a 
                // aucune vente à ce jour alors afficher un msg ellogieux
                MetroFramework.MetroMessageBox.Show(this, "\n\n\nAucune vente n'a eu lieu à ce jour !", "INFORMATION !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private DataTable getAllOperationByDateTime()
        {

            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.connectionString()))
            {
                // creer une requette sql
                using (SqlCommand cmd = new SqlCommand("usp_GET_operation_byDateTimes", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // on a créer provisoirement une datetime 
                    // mais à l'origine c'est l'utilisateur qui doit fournir une date voulue
                    cmd.Parameters.AddWithValue("@DateTime", System.DateTime.Today);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;

                }
            }
        }

    }
}

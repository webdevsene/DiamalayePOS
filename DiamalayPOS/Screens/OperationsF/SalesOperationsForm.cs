using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiamalayPOS.General;
using System.Data.SqlClient;

namespace DiamalayPOS.Screens.OperationsF
{
    public partial class SalesOperationsForm : MetroFramework.Forms.MetroForm
    {
        public SalesOperationsForm()
        {
            InitializeComponent();
        }

        private void BtnCloseopscreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSaveoperation_Click(object sender, EventArgs e)
        {
            if (IsValide())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.connectionString()))
                {
                    try
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand ("usp_Operation_InsertNewOp", con))
                        {
                            //TODO SOMETHING statement

                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@DateTimeOperation", Dtoperation.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@NomArticle", cbxArtcl.GetItemText(cbxArtcl.SelectedItem)); // something wrong here earler
                            cmd.Parameters.AddWithValue("@MobileClient", txtMobileClt.Text);
                            cmd.Parameters.AddWithValue("@Quantite", txtQttcmd.Text);
                            cmd.Parameters.AddWithValue("@PrixNetPaye", txtPrixNetPaye.Text);

                            int id = Convert.ToInt32(cmd.ExecuteScalar()); // execute query

                            ClearData();

                            // Apres insertion il faut laisser à l'utilisateur un msg élogieux


                            DataTable dt = new DataTable();

                            SqlDataAdapter da = new SqlDataAdapter("usp_SELECT_AllOpearationData", con);
                            da.SelectCommand.CommandType = CommandType.StoredProcedure;
                            da.Fill(dt);
                            dtgvlistopera.DataSource = dt;

                            MessageBox.Show("L'opération a réussi avec succès !", "Formm Validation lok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
                    catch (Exception)
                {

                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
            }
        }

        private void ClearData()
        {
            txtMobileClt.Clear(); 
            txtPrixNetPaye.Clear();
            txtQttcmd.Clear();
            txtMobileClt.Focus();
        }

        private bool IsValide()
        {
            // validation form pour les operations
            if (txtPrixNetPaye.Text.Trim() == string.Empty)
            {
                MessageBox.Show("LE prix de l'achat est requis", "Wrong credential !" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrixNetPaye.Focus();
                return false;
            }
            if (txtQttcmd.Text.Trim() == string.Empty)
            {
                MessageBox.Show("LE prix de l'achat est requis", "Wrong credential !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQttcmd.Focus();
                return false;
            }

            return true;

        }

        private void SalesOperationsForm_Load(object sender, EventArgs e)
        {
            // quant on va charger cette fenetre on veut loader la liste de tous 
            // les articles dans le dropdownlistArticle

            LoadProductsDataIntoCbx();
        }

        private void LoadProductsDataIntoCbx()
        {
            // cette methode recupere avec une cmd sql la liste des 
            // produits dans une DataSet
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.connectionString()))
            {
                try
                {

                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("usp_loadProductsData_IntoCbx", con))
                    {

                        //SELECT ProduitID, Nomproduit FROM tblProduits ORDER BY ProduitID, Nomproduit

                        da.SelectCommand.CommandType = CommandType.StoredProcedure;                  
                        // Repeat for each parameter present in the Store Procedure.
                        //da.SelectCommand.Parameters.AddWithValue("@ggg", 95);  usp_loadProductsData_IntoCbx
                        da.Fill(ds);

                        cbxArtcl.DisplayMember = "Nomproduit";
                        cbxArtcl.ValueMember = "ProduitID";
                        cbxArtcl.DataSource = ds.Tables[0] ;

                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }

            }
        }
    }
}

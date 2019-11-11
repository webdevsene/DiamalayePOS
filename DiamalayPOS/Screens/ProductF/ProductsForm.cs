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
namespace DiamalayPOS.Screens.ProductF
{
    public partial class ProductsForm : MetroFramework.Forms.MetroForm
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MetroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.connectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Product_InsertNewProduct", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nomproduit", txtProductname.Text);
                        cmd.Parameters.AddWithValue("@CategorieID", cbxCategoriename.SelectedValue);
                        cmd.Parameters.AddWithValue("@FournisseurID", cbxSuppliername.SelectedValue);
                        cmd.Parameters.AddWithValue("@PrixAchat", txtPrixachat.Text);
                        cmd.Parameters.AddWithValue("@PrixVente", txtPrixvente.Text);

                        con.Open();

                        int id = Convert.ToInt32(cmd.ExecuteScalar());

                        ClearData();

                        DataTable dt = new DataTable();
                        /*dt.Columns.Add(new DataColumn("Description article"));
                        dt.Columns.Add(new DataColumn("Prix d'achat"));
                        dt.Columns.Add(new DataColumn("Prix de vente"));*/
                        SqlDataAdapter da = new SqlDataAdapter("SELECT NomProduit, PrixAchat, PrixVente FROM tblProduits", con);
                        da.Fill(dt);
                        dtgvlistproduit.DataSource = dt;

                        MessageBox.Show("Le produit est enregistré avec succès !", "Form Validation lok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
        }

        private void ClearData()
        {
            txtProductname.Clear();
            txtPrixachat.Clear();
            txtPrixvente.Clear();
            txtProductname.Focus();
        }

        private bool IsValid()
        {

            /**
             *  form validation 
             */
            if (txtProductname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Le nom de l'article est requis", "Wrong form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductname.Focus();
                return false;
            }

            if (txtPrixachat.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Le prix d'achat de l'article est requis", "Wrong form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrixachat.Focus();
                return false;
            }

            if (txtPrixvente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Le prix de vente de l'article est requis", "Wrong form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrixvente.Focus();
                return false;
            }

            return true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBoxes();
        }

        private void LoadDataIntoComboBoxes()
        {

            /**
             * une methode backend pour remplire les comboboxes
             */

            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.connectionString()))
            {

                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT CategorieID, Description FROM tblCategories GROUP BY CategorieID, Description", con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        da.Fill(ds);

                        cbxCategoriename.DisplayMember = "Description";
                        cbxCategoriename.ValueMember = "CategorieID";
                        cbxCategoriename.DataSource = ds.Tables[0];

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


                GetSupplierDAta(); // pour remplire le dropdown des fournissuers

                //cbxSuppliername.DataSource = GetSupplierDAta();
            }

        }
            /*
                    private DataSet GetCategorieData()
                    {
                        //DataTable dtbl = new DataTable();

                        DataSet ds = new DataSet();

                        using (SqlConnection con = new SqlConnection(ApplicationSettings.connectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("USP_LoadAllCaategories", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                //cmd.Parameters.AddWithValue("@ListCategorieID");                 

                                *//*con.Open();

                                SqlDataReader sdr = cmd.ExecuteReader();

                                dtbl.Load(sdr);*//*

                                con.Open();
                                SqlDataAdapter da = new SqlDataAdapter(cmd);
                                da.Fill(ds);


                            }

                        }
                            return ds;
                    }*/

            protected void GetSupplierDAta()
            {


                DataSet ds = new DataSet();
                using (SqlConnection con = new SqlConnection(ApplicationSettings.connectionString()))
                {

                    try
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("SELECT SupplierID, Description FROM tblSuppliers GROUP BY SupplierID, Description", con))
                        {
                            SqlDataAdapter da = new SqlDataAdapter();
                            da.SelectCommand = cmd;
                            da.Fill(ds);

                            cbxSuppliername.DisplayMember = "Description";
                            cbxSuppliername.ValueMember = "SupplierID";
                            cbxSuppliername.DataSource = ds.Tables[0];

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

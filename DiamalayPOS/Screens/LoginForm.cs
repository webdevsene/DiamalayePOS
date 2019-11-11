using DiamalayPOS.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DiamalayPOS.Screens;

namespace DiamalayPOS
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // forms validation / credential validation traitement
            if (IsValid())
            {
                /*tring connstring = ApplicationSettings.connectionString();
                MessageBox.Show(connstring , "chaine de connection");*/

            using (SqlConnection con = new SqlConnection(ApplicationSettings.connectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Login_VerifyLoginDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", usenameTbx.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", usenameTbx.Text.Trim());
                        con.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        if (sdr.Read())
                        {
                            //TODO traitement intent forexemple

                            // fermer le login form puis lancer le dashboard form

                            this.Hide();

                            DashboardForm dashboard = new DashboardForm();
                            dashboard.Show();

                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Nom d'utilisateur ou mot de pass invalide", "Wrong credential", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //MessageBox.Show("Nom d'utilisateur ou mot de pass invalide", "Wrong credential", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        private bool IsValid()
        {
            if (usenameTbx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nom d'utilisateur ou Mot de pass invalide", "Wrong credential");
                usenameTbx.Focus();
                return false;
            }

            if (passwordTbx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nom utilisateur ou Mot de pass invalide", "Wrong credential");
                passwordTbx.Focus();
                return false;
            }
            return true;
        }

        private void PasswordTbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

namespace DiamalayPOS.Screens.ProductF
{
    partial class ProductsForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtProductname = new MetroFramework.Controls.MetroTextBox();
            this.cbxCategoriename = new MetroFramework.Controls.MetroComboBox();
            this.txtPrixachat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPrixvente = new MetroFramework.Controls.MetroTextBox();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cbxSuppliername = new MetroFramework.Controls.MetroComboBox();
            this.dtgvlistproduit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlistproduit)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(82, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nom";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.Location = new System.Drawing.Point(174, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 25);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtProductname
            // 
            // 
            // 
            // 
            this.txtProductname.CustomButton.Image = null;
            this.txtProductname.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtProductname.CustomButton.Name = "";
            this.txtProductname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductname.CustomButton.TabIndex = 1;
            this.txtProductname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductname.CustomButton.UseSelectable = true;
            this.txtProductname.CustomButton.Visible = false;
            this.txtProductname.Lines = new string[0];
            this.txtProductname.Location = new System.Drawing.Point(174, 105);
            this.txtProductname.MaxLength = 32767;
            this.txtProductname.Name = "txtProductname";
            this.txtProductname.PasswordChar = '\0';
            this.txtProductname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductname.SelectedText = "";
            this.txtProductname.SelectionLength = 0;
            this.txtProductname.SelectionStart = 0;
            this.txtProductname.ShortcutsEnabled = true;
            this.txtProductname.Size = new System.Drawing.Size(167, 23);
            this.txtProductname.TabIndex = 1;
            this.txtProductname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtProductname.UseSelectable = true;
            this.txtProductname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductname.Click += new System.EventHandler(this.MetroTextBox1_Click);
            // 
            // cbxCategoriename
            // 
            this.cbxCategoriename.FormattingEnabled = true;
            this.cbxCategoriename.ItemHeight = 23;
            this.cbxCategoriename.Location = new System.Drawing.Point(174, 146);
            this.cbxCategoriename.Name = "cbxCategoriename";
            this.cbxCategoriename.Size = new System.Drawing.Size(148, 29);
            this.cbxCategoriename.TabIndex = 2;
            this.cbxCategoriename.UseSelectable = true;
            this.cbxCategoriename.SelectedIndexChanged += new System.EventHandler(this.MetroComboBox1_SelectedIndexChanged);
            // 
            // txtPrixachat
            // 
            // 
            // 
            // 
            this.txtPrixachat.CustomButton.Image = null;
            this.txtPrixachat.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtPrixachat.CustomButton.Name = "";
            this.txtPrixachat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrixachat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrixachat.CustomButton.TabIndex = 1;
            this.txtPrixachat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrixachat.CustomButton.UseSelectable = true;
            this.txtPrixachat.CustomButton.Visible = false;
            this.txtPrixachat.Lines = new string[0];
            this.txtPrixachat.Location = new System.Drawing.Point(174, 236);
            this.txtPrixachat.MaxLength = 32767;
            this.txtPrixachat.Name = "txtPrixachat";
            this.txtPrixachat.PasswordChar = '\0';
            this.txtPrixachat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrixachat.SelectedText = "";
            this.txtPrixachat.SelectionLength = 0;
            this.txtPrixachat.SelectionStart = 0;
            this.txtPrixachat.ShortcutsEnabled = true;
            this.txtPrixachat.Size = new System.Drawing.Size(100, 23);
            this.txtPrixachat.TabIndex = 4;
            this.txtPrixachat.UseSelectable = true;
            this.txtPrixachat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrixachat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(82, 156);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Catégorie";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(82, 196);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Fournisseur";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(82, 236);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(81, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Prix d\' achat";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(78, 277);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(85, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Prix de vente";
            // 
            // txtPrixvente
            // 
            // 
            // 
            // 
            this.txtPrixvente.CustomButton.Image = null;
            this.txtPrixvente.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtPrixvente.CustomButton.Name = "";
            this.txtPrixvente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrixvente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrixvente.CustomButton.TabIndex = 1;
            this.txtPrixvente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrixvente.CustomButton.UseSelectable = true;
            this.txtPrixvente.CustomButton.Visible = false;
            this.txtPrixvente.Lines = new string[0];
            this.txtPrixvente.Location = new System.Drawing.Point(174, 273);
            this.txtPrixvente.MaxLength = 32767;
            this.txtPrixvente.Name = "txtPrixvente";
            this.txtPrixvente.PasswordChar = '\0';
            this.txtPrixvente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrixvente.SelectedText = "";
            this.txtPrixvente.SelectionLength = 0;
            this.txtPrixvente.SelectionStart = 0;
            this.txtPrixvente.ShortcutsEnabled = true;
            this.txtPrixvente.Size = new System.Drawing.Size(100, 23);
            this.txtPrixvente.TabIndex = 5;
            this.txtPrixvente.UseSelectable = true;
            this.txtPrixvente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrixvente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose.Location = new System.Drawing.Point(174, 353);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(167, 25);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Quitter";
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNew.Location = new System.Drawing.Point(437, 353);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(192, 25);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "Nouveau article";
            this.btnNew.UseCustomBackColor = true;
            this.btnNew.UseCustomForeColor = true;
            this.btnNew.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel7.Location = new System.Drawing.Point(23, 417);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(241, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Powered by seneo-soft IT solution";
            // 
            // cbxSuppliername
            // 
            this.cbxSuppliername.FormattingEnabled = true;
            this.cbxSuppliername.ItemHeight = 23;
            this.cbxSuppliername.Location = new System.Drawing.Point(174, 186);
            this.cbxSuppliername.Name = "cbxSuppliername";
            this.cbxSuppliername.Size = new System.Drawing.Size(148, 29);
            this.cbxSuppliername.TabIndex = 3;
            this.cbxSuppliername.UseSelectable = true;
            // 
            // dtgvlistproduit
            // 
            this.dtgvlistproduit.AllowUserToDeleteRows = false;
            this.dtgvlistproduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvlistproduit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvlistproduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvlistproduit.Location = new System.Drawing.Point(360, 63);
            this.dtgvlistproduit.Name = "dtgvlistproduit";
            this.dtgvlistproduit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtgvlistproduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvlistproduit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvlistproduit.Size = new System.Drawing.Size(439, 284);
            this.dtgvlistproduit.StandardTab = true;
            this.dtgvlistproduit.TabIndex = 9;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 444);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtPrixvente);
            this.Controls.Add(this.cbxSuppliername);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtPrixachat);
            this.Controls.Add(this.cbxCategoriename);
            this.Controls.Add(this.txtProductname);
            this.Controls.Add(this.dtgvlistproduit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(840, 380);
            this.Name = "ProductsForm";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Diamalay Point Of Sales | Ajouter un produit";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlistproduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtProductname;
        private MetroFramework.Controls.MetroComboBox cbxCategoriename;
        private MetroFramework.Controls.MetroTextBox txtPrixachat;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtPrixvente;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cbxSuppliername;
        private System.Windows.Forms.DataGridView dtgvlistproduit;
    }
}
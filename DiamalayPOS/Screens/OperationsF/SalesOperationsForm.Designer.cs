namespace DiamalayPOS.Screens.OperationsF
{
    partial class SalesOperationsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnNewoperation = new MetroFramework.Controls.MetroButton();
            this.btnCloseopscreen = new MetroFramework.Controls.MetroButton();
            this.txtQttcmd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPrixNetPaye = new MetroFramework.Controls.MetroTextBox();
            this.cbxArtcl = new MetroFramework.Controls.MetroComboBox();
            this.txtMobileClt = new MetroFramework.Controls.MetroTextBox();
            this.btnSaveoperation = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Dtoperation = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtgvlistopera = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlistopera)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel7.Location = new System.Drawing.Point(23, 457);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(241, 19);
            this.metroLabel7.TabIndex = 28;
            this.metroLabel7.Text = "Powered by seneo-soft IT solution";
            // 
            // btnNewoperation
            // 
            this.btnNewoperation.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNewoperation.Location = new System.Drawing.Point(363, 391);
            this.btnNewoperation.Name = "btnNewoperation";
            this.btnNewoperation.Size = new System.Drawing.Size(129, 25);
            this.btnNewoperation.TabIndex = 9;
            this.btnNewoperation.Text = "Nouveau article";
            this.btnNewoperation.UseCustomBackColor = true;
            this.btnNewoperation.UseCustomForeColor = true;
            this.btnNewoperation.UseSelectable = true;
            // 
            // btnCloseopscreen
            // 
            this.btnCloseopscreen.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCloseopscreen.Location = new System.Drawing.Point(267, 391);
            this.btnCloseopscreen.Name = "btnCloseopscreen";
            this.btnCloseopscreen.Size = new System.Drawing.Size(77, 25);
            this.btnCloseopscreen.TabIndex = 7;
            this.btnCloseopscreen.Text = "&Quitter";
            this.btnCloseopscreen.UseCustomBackColor = true;
            this.btnCloseopscreen.UseCustomForeColor = true;
            this.btnCloseopscreen.UseSelectable = true;
            this.btnCloseopscreen.Click += new System.EventHandler(this.BtnCloseopscreen_Click);
            // 
            // txtQttcmd
            // 
            // 
            // 
            // 
            this.txtQttcmd.CustomButton.Image = null;
            this.txtQttcmd.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtQttcmd.CustomButton.Name = "";
            this.txtQttcmd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQttcmd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQttcmd.CustomButton.TabIndex = 1;
            this.txtQttcmd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQttcmd.CustomButton.UseSelectable = true;
            this.txtQttcmd.CustomButton.Visible = false;
            this.txtQttcmd.Lines = new string[0];
            this.txtQttcmd.Location = new System.Drawing.Point(177, 304);
            this.txtQttcmd.MaxLength = 32767;
            this.txtQttcmd.Name = "txtQttcmd";
            this.txtQttcmd.PasswordChar = '\0';
            this.txtQttcmd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQttcmd.SelectedText = "";
            this.txtQttcmd.SelectionLength = 0;
            this.txtQttcmd.SelectionStart = 0;
            this.txtQttcmd.ShortcutsEnabled = true;
            this.txtQttcmd.Size = new System.Drawing.Size(100, 23);
            this.txtQttcmd.TabIndex = 4;
            this.txtQttcmd.UseSelectable = true;
            this.txtQttcmd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQttcmd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(77, 308);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(89, 19);
            this.metroLabel6.TabIndex = 27;
            this.metroLabel6.Text = "Quantité cmd";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(77, 260);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 19);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Prix Net payé";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(78, 210);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Article";
            // 
            // txtPrixNetPaye
            // 
            // 
            // 
            // 
            this.txtPrixNetPaye.CustomButton.Image = null;
            this.txtPrixNetPaye.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtPrixNetPaye.CustomButton.Name = "";
            this.txtPrixNetPaye.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrixNetPaye.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrixNetPaye.CustomButton.TabIndex = 1;
            this.txtPrixNetPaye.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrixNetPaye.CustomButton.UseSelectable = true;
            this.txtPrixNetPaye.CustomButton.Visible = false;
            this.txtPrixNetPaye.Lines = new string[0];
            this.txtPrixNetPaye.Location = new System.Drawing.Point(177, 260);
            this.txtPrixNetPaye.MaxLength = 32767;
            this.txtPrixNetPaye.Name = "txtPrixNetPaye";
            this.txtPrixNetPaye.PasswordChar = '\0';
            this.txtPrixNetPaye.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrixNetPaye.SelectedText = "";
            this.txtPrixNetPaye.SelectionLength = 0;
            this.txtPrixNetPaye.SelectionStart = 0;
            this.txtPrixNetPaye.ShortcutsEnabled = true;
            this.txtPrixNetPaye.Size = new System.Drawing.Size(100, 23);
            this.txtPrixNetPaye.TabIndex = 3;
            this.txtPrixNetPaye.UseSelectable = true;
            this.txtPrixNetPaye.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrixNetPaye.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbxArtcl
            // 
            this.cbxArtcl.FormattingEnabled = true;
            this.cbxArtcl.ItemHeight = 23;
            this.cbxArtcl.Location = new System.Drawing.Point(177, 210);
            this.cbxArtcl.Name = "cbxArtcl";
            this.cbxArtcl.Size = new System.Drawing.Size(148, 29);
            this.cbxArtcl.TabIndex = 2;
            this.cbxArtcl.UseSelectable = true;
            // 
            // txtMobileClt
            // 
            // 
            // 
            // 
            this.txtMobileClt.CustomButton.Image = null;
            this.txtMobileClt.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtMobileClt.CustomButton.Name = "";
            this.txtMobileClt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMobileClt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMobileClt.CustomButton.TabIndex = 1;
            this.txtMobileClt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMobileClt.CustomButton.UseSelectable = true;
            this.txtMobileClt.CustomButton.Visible = false;
            this.txtMobileClt.Lines = new string[0];
            this.txtMobileClt.Location = new System.Drawing.Point(177, 161);
            this.txtMobileClt.MaxLength = 32767;
            this.txtMobileClt.Name = "txtMobileClt";
            this.txtMobileClt.PasswordChar = '\0';
            this.txtMobileClt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMobileClt.SelectedText = "";
            this.txtMobileClt.SelectionLength = 0;
            this.txtMobileClt.SelectionStart = 0;
            this.txtMobileClt.ShortcutsEnabled = true;
            this.txtMobileClt.Size = new System.Drawing.Size(166, 23);
            this.txtMobileClt.TabIndex = 1;
            this.txtMobileClt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMobileClt.UseSelectable = true;
            this.txtMobileClt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMobileClt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSaveoperation
            // 
            this.btnSaveoperation.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveoperation.Location = new System.Drawing.Point(178, 391);
            this.btnSaveoperation.Name = "btnSaveoperation";
            this.btnSaveoperation.Size = new System.Drawing.Size(79, 25);
            this.btnSaveoperation.TabIndex = 6;
            this.btnSaveoperation.Text = "Enregistrer";
            this.btnSaveoperation.UseCustomBackColor = true;
            this.btnSaveoperation.UseCustomForeColor = true;
            this.btnSaveoperation.UseSelectable = true;
            this.btnSaveoperation.UseStyleColors = true;
            this.btnSaveoperation.Click += new System.EventHandler(this.BtnSaveoperation_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(74, 161);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Mobile Client";
            // 
            // Dtoperation
            // 
            this.Dtoperation.Location = new System.Drawing.Point(177, 344);
            this.Dtoperation.MinimumSize = new System.Drawing.Size(0, 29);
            this.Dtoperation.Name = "Dtoperation";
            this.Dtoperation.Size = new System.Drawing.Size(167, 29);
            this.Dtoperation.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(74, 344);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Date operation";
            // 
            // dtgvlistopera
            // 
            this.dtgvlistopera.AllowUserToResizeColumns = false;
            this.dtgvlistopera.AllowUserToResizeRows = false;
            this.dtgvlistopera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvlistopera.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvlistopera.BackgroundColor = System.Drawing.Color.White;
            this.dtgvlistopera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvlistopera.CausesValidation = false;
            this.dtgvlistopera.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvlistopera.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvlistopera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvlistopera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvlistopera.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvlistopera.EnableHeadersVisualStyles = false;
            this.dtgvlistopera.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgvlistopera.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvlistopera.Location = new System.Drawing.Point(363, 70);
            this.dtgvlistopera.Name = "dtgvlistopera";
            this.dtgvlistopera.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvlistopera.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvlistopera.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvlistopera.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvlistopera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvlistopera.Size = new System.Drawing.Size(432, 315);
            this.dtgvlistopera.TabIndex = 31;
            // 
            // SalesOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 480);
            this.Controls.Add(this.dtgvlistopera);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Dtoperation);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.btnNewoperation);
            this.Controls.Add(this.btnCloseopscreen);
            this.Controls.Add(this.txtQttcmd);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtPrixNetPaye);
            this.Controls.Add(this.cbxArtcl);
            this.Controls.Add(this.txtMobileClt);
            this.Controls.Add(this.btnSaveoperation);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(840, 480);
            this.Name = "SalesOperationsForm";
            this.Resizable = false;
            this.Text = "Diamalay Point Of Sales | Opération de Vente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SalesOperationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlistopera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btnNewoperation;
        private MetroFramework.Controls.MetroButton btnCloseopscreen;
        private MetroFramework.Controls.MetroTextBox txtQttcmd;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtPrixNetPaye;
        private MetroFramework.Controls.MetroComboBox cbxArtcl;
        private MetroFramework.Controls.MetroTextBox txtMobileClt;
        private MetroFramework.Controls.MetroButton btnSaveoperation;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime Dtoperation;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid dtgvlistopera;
    }
}
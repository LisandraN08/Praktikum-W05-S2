
namespace Praktikum_W05_S2
{
    partial class Form1
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
            this.lblData = new System.Windows.Forms.Label();
            this.txtBoxInputData = new System.Windows.Forms.TextBox();
            this.btnAddData = new System.Windows.Forms.Button();
            this.lblKoleksi = new System.Windows.Forms.Label();
            this.lblSetting = new System.Windows.Forms.Label();
            this.lBoxKoleksi = new System.Windows.Forms.ListBox();
            this.cBoxAktif = new System.Windows.Forms.CheckBox();
            this.radioBtnMerah = new System.Windows.Forms.RadioButton();
            this.radioBtnBiru = new System.Windows.Forms.RadioButton();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblViewOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(59, 39);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 17);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data:";
            // 
            // txtBoxInputData
            // 
            this.txtBoxInputData.Location = new System.Drawing.Point(107, 36);
            this.txtBoxInputData.Name = "txtBoxInputData";
            this.txtBoxInputData.Size = new System.Drawing.Size(275, 22);
            this.txtBoxInputData.TabIndex = 1;
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(400, 36);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(75, 23);
            this.btnAddData.TabIndex = 2;
            this.btnAddData.Text = "Add";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // lblKoleksi
            // 
            this.lblKoleksi.AutoSize = true;
            this.lblKoleksi.Location = new System.Drawing.Point(59, 103);
            this.lblKoleksi.Name = "lblKoleksi";
            this.lblKoleksi.Size = new System.Drawing.Size(57, 17);
            this.lblKoleksi.TabIndex = 3;
            this.lblKoleksi.Text = "Koleksi:";
            // 
            // lblSetting
            // 
            this.lblSetting.AutoSize = true;
            this.lblSetting.Location = new System.Drawing.Point(397, 103);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(56, 17);
            this.lblSetting.TabIndex = 5;
            this.lblSetting.Text = "Setting:";
            // 
            // lBoxKoleksi
            // 
            this.lBoxKoleksi.FormattingEnabled = true;
            this.lBoxKoleksi.ItemHeight = 16;
            this.lBoxKoleksi.Location = new System.Drawing.Point(62, 139);
            this.lBoxKoleksi.Name = "lBoxKoleksi";
            this.lBoxKoleksi.Size = new System.Drawing.Size(320, 276);
            this.lBoxKoleksi.TabIndex = 6;
            this.lBoxKoleksi.SelectedIndexChanged += new System.EventHandler(this.lBoxKoleksi_SelectedIndexChanged);
            // 
            // cBoxAktif
            // 
            this.cBoxAktif.AutoSize = true;
            this.cBoxAktif.Location = new System.Drawing.Point(460, 103);
            this.cBoxAktif.Name = "cBoxAktif";
            this.cBoxAktif.Size = new System.Drawing.Size(57, 21);
            this.cBoxAktif.TabIndex = 7;
            this.cBoxAktif.Text = "Aktif";
            this.cBoxAktif.UseVisualStyleBackColor = true;
            this.cBoxAktif.CheckedChanged += new System.EventHandler(this.cBoxAktif_CheckedChanged);
            // 
            // radioBtnMerah
            // 
            this.radioBtnMerah.AutoSize = true;
            this.radioBtnMerah.Enabled = false;
            this.radioBtnMerah.Location = new System.Drawing.Point(430, 139);
            this.radioBtnMerah.Name = "radioBtnMerah";
            this.radioBtnMerah.Size = new System.Drawing.Size(115, 21);
            this.radioBtnMerah.TabIndex = 8;
            this.radioBtnMerah.TabStop = true;
            this.radioBtnMerah.Text = "Warna Merah";
            this.radioBtnMerah.UseVisualStyleBackColor = true;
            this.radioBtnMerah.CheckedChanged += new System.EventHandler(this.radioBtnMerah_CheckedChanged);
            // 
            // radioBtnBiru
            // 
            this.radioBtnBiru.AutoSize = true;
            this.radioBtnBiru.Enabled = false;
            this.radioBtnBiru.Location = new System.Drawing.Point(430, 166);
            this.radioBtnBiru.Name = "radioBtnBiru";
            this.radioBtnBiru.Size = new System.Drawing.Size(100, 21);
            this.radioBtnBiru.TabIndex = 9;
            this.radioBtnBiru.TabStop = true;
            this.radioBtnBiru.Text = "Warna Biru";
            this.radioBtnBiru.UseVisualStyleBackColor = true;
            this.radioBtnBiru.CheckedChanged += new System.EventHandler(this.radioBtnBiru_CheckedChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(397, 215);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(55, 17);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "Output:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(400, 392);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(320, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblViewOutput
            // 
            this.lblViewOutput.AutoSize = true;
            this.lblViewOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewOutput.Location = new System.Drawing.Point(501, 276);
            this.lblViewOutput.Name = "lblViewOutput";
            this.lblViewOutput.Size = new System.Drawing.Size(0, 29);
            this.lblViewOutput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblViewOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.radioBtnBiru);
            this.Controls.Add(this.radioBtnMerah);
            this.Controls.Add(this.cBoxAktif);
            this.Controls.Add(this.lBoxKoleksi);
            this.Controls.Add(this.lblSetting);
            this.Controls.Add(this.lblKoleksi);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.txtBoxInputData);
            this.Controls.Add(this.lblData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtBoxInputData;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Label lblKoleksi;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.ListBox lBoxKoleksi;
        private System.Windows.Forms.CheckBox cBoxAktif;
        private System.Windows.Forms.RadioButton radioBtnMerah;
        private System.Windows.Forms.RadioButton radioBtnBiru;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblViewOutput;
    }
}


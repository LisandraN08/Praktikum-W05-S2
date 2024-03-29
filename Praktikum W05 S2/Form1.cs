﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_W05_S2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DataTable dataInputan = new DataTable();
        public void Form1_Load(object sender, EventArgs e)
        {
            dataInputan.Columns.Add("Inputan");

        }
        public void btnAddData_Click(object sender, EventArgs e)
        {
            if (lBoxKoleksi.Items.Contains(txtBoxInputData.Text))
            {
                MessageBox.Show("Input kembar");
            }
            else
            {
                lBoxKoleksi.Items.Add(txtBoxInputData.Text);
            }

        }

        private void lBoxKoleksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblViewOutput.Text = lBoxKoleksi.Text;
        }

        private void cBoxAktif_CheckedChanged (object sender, EventArgs e)
        {
            if (cBoxAktif.Checked == true)
            {
                radioBtnMerah.Enabled = true;
                radioBtnBiru.Enabled = true;
            }
            else
            {
                radioBtnMerah.Enabled = false;
                radioBtnBiru.Enabled = false;
            }

        }
        private void radioBtnMerah_CheckedChanged(object sender, EventArgs e)
        {
            lblViewOutput.ForeColor = Color.Red;
        }

        private void radioBtnBiru_CheckedChanged(object sender, EventArgs e)
        {
            lblViewOutput.ForeColor = Color.Blue;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lBoxKoleksi.Items.Clear();
            dataInputan.Clear();
            txtBoxInputData.Clear();
            lblViewOutput.Text = "";
            cBoxAktif.Checked = false;
        }
    }
}

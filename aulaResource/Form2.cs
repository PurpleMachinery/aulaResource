using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace aulaResource
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanguage.SelectedItem.ToString() == "Português")
            {
                alterarIdioma("pt-br");
            }
            else if (cmbLanguage.SelectedItem.ToString() == "Ingles")
            {
                alterarIdioma("en");
            }
            else if (cmbLanguage.SelectedItem.ToString() == "Espanhol")
            {
                alterarIdioma("es");
            }

        }

        private void alterarIdioma(String bozo)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo(bozo));
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbLanguage.Items.Add("Português");
            cmbLanguage.Items.Add("Ingles");
            cmbLanguage.Items.Add("Espanhol");
        }
    }
}

using System;
using System.Windows.Forms;
using SuggestControl;

namespace Suggest_csharp
{
    public partial class DemoSuggest : Form
    {
        public DemoSuggest()
        {
            InitializeComponent();
        }

        private void cbSoloComuni_CheckedChanged(object sender, EventArgs e)
        {
            txtSuggestComune.TownOutput = cbSoloComuni.Checked ? TownOutputEnum.Town : TownOutputEnum.All;
        }

        private void txtSuggestComune_TownSelected(object sender, SelectTownEventArgs e)
        {
            txtProvincia.Text = e.Town.Province;
            txtCap.Text = e.Town.Zip;
            txtFrazione.Text = e.Town.Village;
            txtParticella.Text = string.Empty;
            txtToponimo.Text = string.Empty;
     
        }

        private void txtSuggestIndirizzo_StreetSelected(object sender, SelectStreetEventArgs e)
        {
            txtCap.Text = e.Street.Zip;
            txtParticella.Text = e.Street.StreetType;
            txtToponimo.Text = e.Street.StreetName;
            txtFrazione.Text = e.Street.Village;
        }

        private void txtSuggestComune_TextChanged(object sender, EventArgs e)
        {
            txtProvincia.Text = string.Empty;
            txtCap.Text = string.Empty;
            txtFrazione.Text = string.Empty;
            txtParticella.Text = string.Empty;
            txtToponimo.Text = string.Empty;
        }

        private void txtStreetMasterKey_TextChanged(object sender, EventArgs e)
        {
            if (txtStreetMasterKey.Text.Trim()!= string.Empty)
            {
                txtSuggestComune.StreetMasterKey= txtStreetMasterKey.Text;
                txtSuggestIndirizzo.StreetMasterKey = txtStreetMasterKey.Text;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.streetmaster.it");
        }
    } 
}

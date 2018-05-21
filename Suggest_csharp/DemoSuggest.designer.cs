namespace Suggest_csharp
{
    partial class DemoSuggest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoSuggest));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFrazione = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtToponimo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtParticella = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCap = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtSuggestIndirizzo = new SuggestControl.SuggestStreet();
            this.txtSuggestComune = new SuggestControl.SuggestTown();
            this.cbSoloComuni = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStreetMasterKey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFrazione);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtToponimo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtParticella);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCap);
            this.groupBox1.Controls.Add(this.txtProvincia);
            this.groupBox1.Controls.Add(this.txtSuggestIndirizzo);
            this.groupBox1.Controls.Add(this.txtSuggestComune);
            this.groupBox1.Controls.Add(this.cbSoloComuni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 236);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtFrazione
            // 
            this.txtFrazione.Enabled = false;
            this.txtFrazione.Location = new System.Drawing.Point(18, 88);
            this.txtFrazione.Name = "txtFrazione";
            this.txtFrazione.ReadOnly = true;
            this.txtFrazione.Size = new System.Drawing.Size(319, 20);
            this.txtFrazione.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Frazione";
            // 
            // txtToponimo
            // 
            this.txtToponimo.Enabled = false;
            this.txtToponimo.Location = new System.Drawing.Point(136, 187);
            this.txtToponimo.Name = "txtToponimo";
            this.txtToponimo.ReadOnly = true;
            this.txtToponimo.Size = new System.Drawing.Size(319, 20);
            this.txtToponimo.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Toponimo";
            // 
            // txtParticella
            // 
            this.txtParticella.Enabled = false;
            this.txtParticella.Location = new System.Drawing.Point(17, 187);
            this.txtParticella.Name = "txtParticella";
            this.txtParticella.ReadOnly = true;
            this.txtParticella.Size = new System.Drawing.Size(85, 20);
            this.txtParticella.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Particella";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Provincia";
            // 
            // txtCap
            // 
            this.txtCap.Location = new System.Drawing.Point(420, 32);
            this.txtCap.Name = "txtCap";
            this.txtCap.ReadOnly = true;
            this.txtCap.Size = new System.Drawing.Size(60, 20);
            this.txtCap.TabIndex = 12;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Enabled = false;
            this.txtProvincia.Location = new System.Drawing.Point(352, 32);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.ReadOnly = true;
            this.txtProvincia.Size = new System.Drawing.Size(34, 20);
            this.txtProvincia.TabIndex = 10;
            // 
            // txtSuggestIndirizzo
            // 
            this.txtSuggestIndirizzo.DisableAutocomplete = false;
            this.txtSuggestIndirizzo.Location = new System.Drawing.Point(18, 144);
            this.txtSuggestIndirizzo.Name = "txtSuggestIndirizzo";
            this.txtSuggestIndirizzo.Size = new System.Drawing.Size(319, 20);
            this.txtSuggestIndirizzo.StreetMasterKey = "Inserire la chiave StreetMaster";
            this.txtSuggestIndirizzo.SuggestTownLinked = "txtSuggestComune";
            this.txtSuggestIndirizzo.TabIndex = 9;
            this.txtSuggestIndirizzo.StreetSelect += new System.EventHandler<SuggestControl.SuggestStreet.SelectStreetEventArgs>(this.txtSuggestIndirizzo_StreetSelect);
            // 
            // txtSuggestComune
            // 
            this.txtSuggestComune.DisableAutocomplete = false;
            this.txtSuggestComune.Location = new System.Drawing.Point(18, 32);
            this.txtSuggestComune.Name = "txtSuggestComune";
            this.txtSuggestComune.Size = new System.Drawing.Size(319, 20);
            this.txtSuggestComune.StreetMasterKey = "Inserire la chiave StreetMaster";
            this.txtSuggestComune.TabIndex = 8;
            this.txtSuggestComune.TownOutput = SuggestControl.Data.DataUtil.TownOutputEnum.All;
            this.txtSuggestComune.TownSelect += new System.EventHandler<SuggestControl.SelectTownEventArgs>(this.txtSuggestComune_TownSelect);
            this.txtSuggestComune.TextChanged += new System.EventHandler(this.txtSuggestComune_TextChanged);
            // 
            // cbSoloComuni
            // 
            this.cbSoloComuni.AutoSize = true;
            this.cbSoloComuni.Checked = true;
            this.cbSoloComuni.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSoloComuni.Location = new System.Drawing.Point(18, 54);
            this.cbSoloComuni.Name = "cbSoloComuni";
            this.cbSoloComuni.Size = new System.Drawing.Size(84, 17);
            this.cbSoloComuni.TabIndex = 7;
            this.cbSoloComuni.Text = "Solo comuni";
            this.cbSoloComuni.UseVisualStyleBackColor = true;
            this.cbSoloComuni.CheckedChanged += new System.EventHandler(this.cbSoloComuni_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Indirizzo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Comune";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "StreetMaster key";
            // 
            // txtStreetMasterKey
            // 
            this.txtStreetMasterKey.Location = new System.Drawing.Point(271, 28);
            this.txtStreetMasterKey.Name = "txtStreetMasterKey";
            this.txtStreetMasterKey.Size = new System.Drawing.Size(122, 20);
            this.txtStreetMasterKey.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "ATTENZIONE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(267, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Prima dell\'utilizzo inserire la chiave del servizio Suggest.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(285, 344);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(196, 13);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Per richiederla visita www.streetmaster.it";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DemoSuggest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 369);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStreetMasterKey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DemoSuggest";
            this.Text = "DemoSuggest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbSoloComuni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SuggestControl.SuggestStreet txtSuggestIndirizzo;
        private SuggestControl.SuggestTown txtSuggestComune;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCap;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtFrazione;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtToponimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtParticella;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStreetMasterKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
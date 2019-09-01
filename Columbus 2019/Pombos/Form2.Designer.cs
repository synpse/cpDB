namespace Columbus2019
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtPopName = new System.Windows.Forms.Label();
            this.txtPopNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPopMom = new System.Windows.Forms.Label();
            this.txtPopDad = new System.Windows.Forms.Label();
            this.txtPopGender = new System.Windows.Forms.Label();
            this.txtPopNotes = new System.Windows.Forms.TextBox();
            this.UpdateProfile = new System.Windows.Forms.Button();
            this.txtPopState = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPopName
            // 
            this.txtPopName.AutoSize = true;
            this.txtPopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPopName.Location = new System.Drawing.Point(220, 12);
            this.txtPopName.Name = "txtPopName";
            this.txtPopName.Size = new System.Drawing.Size(93, 36);
            this.txtPopName.TabIndex = 0;
            this.txtPopName.Text = "Nome";
            // 
            // txtPopNumber
            // 
            this.txtPopNumber.AutoSize = true;
            this.txtPopNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPopNumber.Location = new System.Drawing.Point(221, 48);
            this.txtPopNumber.Name = "txtPopNumber";
            this.txtPopNumber.Size = new System.Drawing.Size(103, 29);
            this.txtPopNumber.TabIndex = 1;
            this.txtPopNumber.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Género:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Progenitor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Progenitora:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPopMom
            // 
            this.txtPopMom.AutoSize = true;
            this.txtPopMom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPopMom.Location = new System.Drawing.Point(342, 143);
            this.txtPopMom.Name = "txtPopMom";
            this.txtPopMom.Size = new System.Drawing.Size(100, 20);
            this.txtPopMom.TabIndex = 7;
            this.txtPopMom.Text = "NúmeroMãe";
            this.txtPopMom.Click += new System.EventHandler(this.txtPopMom_Click);
            // 
            // txtPopDad
            // 
            this.txtPopDad.AutoSize = true;
            this.txtPopDad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPopDad.Location = new System.Drawing.Point(342, 115);
            this.txtPopDad.Name = "txtPopDad";
            this.txtPopDad.Size = new System.Drawing.Size(92, 20);
            this.txtPopDad.TabIndex = 6;
            this.txtPopDad.Text = "NúmeroPai";
            this.txtPopDad.Click += new System.EventHandler(this.txtPopDad_Click);
            // 
            // txtPopGender
            // 
            this.txtPopGender.AutoSize = true;
            this.txtPopGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPopGender.Location = new System.Drawing.Point(342, 86);
            this.txtPopGender.Name = "txtPopGender";
            this.txtPopGender.Size = new System.Drawing.Size(64, 20);
            this.txtPopGender.TabIndex = 5;
            this.txtPopGender.Text = "Género";
            this.txtPopGender.Click += new System.EventHandler(this.txtPopGender_Click);
            // 
            // txtPopNotes
            // 
            this.txtPopNotes.Location = new System.Drawing.Point(226, 191);
            this.txtPopNotes.Multiline = true;
            this.txtPopNotes.Name = "txtPopNotes";
            this.txtPopNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPopNotes.Size = new System.Drawing.Size(562, 247);
            this.txtPopNotes.TabIndex = 8;
            // 
            // UpdateProfile
            // 
            this.UpdateProfile.Location = new System.Drawing.Point(12, 410);
            this.UpdateProfile.Name = "UpdateProfile";
            this.UpdateProfile.Size = new System.Drawing.Size(180, 28);
            this.UpdateProfile.TabIndex = 9;
            this.UpdateProfile.Text = "Atualizar";
            this.UpdateProfile.UseVisualStyleBackColor = true;
            this.UpdateProfile.Click += new System.EventHandler(this.UpdateProfile_Click);
            // 
            // txtPopState
            // 
            this.txtPopState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPopState.FormattingEnabled = true;
            this.txtPopState.Items.AddRange(new object[] {
            "[Apto / Saudável]",
            "[Inapto / Doente]",
            "Morto",
            "Dado / Vendido",
            "Devolvido"});
            this.txtPopState.Location = new System.Drawing.Point(12, 198);
            this.txtPopState.Name = "txtPopState";
            this.txtPopState.Size = new System.Drawing.Size(180, 21);
            this.txtPopState.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPopState);
            this.Controls.Add(this.UpdateProfile);
            this.Controls.Add(this.txtPopNotes);
            this.Controls.Add(this.txtPopMom);
            this.Controls.Add(this.txtPopDad);
            this.Controls.Add(this.txtPopGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPopNumber);
            this.Controls.Add(this.txtPopName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPopName;
        private System.Windows.Forms.Label txtPopNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtPopMom;
        private System.Windows.Forms.Label txtPopDad;
        private System.Windows.Forms.Label txtPopGender;
        private System.Windows.Forms.TextBox txtPopNotes;
        private System.Windows.Forms.Button UpdateProfile;
        private System.Windows.Forms.ComboBox txtPopState;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
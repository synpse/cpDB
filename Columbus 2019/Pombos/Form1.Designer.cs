namespace Columbus2019
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.txtState = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtDad = new System.Windows.Forms.TextBox();
            this.txtMom = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(10, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Género";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Progenitor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Progenitora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Estado";
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.SystemColors.Window;
            this.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Macho",
            "Fêmea"});
            this.txtGender.Location = new System.Drawing.Point(57, 115);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(136, 21);
            this.txtGender.TabIndex = 16;
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.SystemColors.Window;
            this.txtState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtState.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtState.FormattingEnabled = true;
            this.txtState.Items.AddRange(new object[] {
            "[Apto / Saudável]",
            "[Inapto / Doente]",
            "Morto",
            "Dado / Vendido",
            "Devolvido"});
            this.txtState.Location = new System.Drawing.Point(10, 232);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(183, 21);
            this.txtState.TabIndex = 19;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(10, 514);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(183, 23);
            this.Add.TabIndex = 20;
            this.Add.Text = "Adicionar";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(225, 37);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid.Size = new System.Drawing.Size(742, 593);
            this.Grid.TabIndex = 21;
            this.Grid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.Grid_DataBindingComplete);
            this.Grid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_RowHeaderMouseClick);
            this.Grid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_RowHeaderMouseDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(733, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Procurar";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(786, 11);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(181, 20);
            this.SearchBox.TabIndex = 22;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(10, 543);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(183, 23);
            this.Update.TabIndex = 25;
            this.Update.Text = "Atualizar";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(10, 572);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(183, 23);
            this.Delete.TabIndex = 26;
            this.Delete.Text = "Apagar";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(10, 115);
            this.txtDate.Mask = "0000";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(41, 20);
            this.txtDate.TabIndex = 29;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDate_KeyPress);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(10, 37);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(183, 20);
            this.txtNumber.TabIndex = 30;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // txtDad
            // 
            this.txtDad.Location = new System.Drawing.Point(10, 154);
            this.txtDad.Name = "txtDad";
            this.txtDad.Size = new System.Drawing.Size(183, 20);
            this.txtDad.TabIndex = 31;
            this.txtDad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDad_KeyPress);
            // 
            // txtMom
            // 
            this.txtMom.Location = new System.Drawing.Point(10, 193);
            this.txtMom.Name = "txtMom";
            this.txtMom.Size = new System.Drawing.Size(183, 20);
            this.txtMom.TabIndex = 32;
            this.txtMom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMom_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Fotografia";
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(10, 461);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(64, 23);
            this.Browse.TabIndex = 35;
            this.Browse.Text = "Procurar";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(976, 639);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMom);
            this.Controls.Add(this.txtDad);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.ComboBox txtState;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtDad;
        private System.Windows.Forms.TextBox txtMom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Browse;
    }
}


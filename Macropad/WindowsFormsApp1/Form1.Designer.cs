namespace WindowsFormsApp1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KeyLabel1 = new System.Windows.Forms.Label();
            this.KeyLabel2 = new System.Windows.Forms.Label();
            this.KeyLabel3 = new System.Windows.Forms.Label();
            this.KeyLabel6 = new System.Windows.Forms.Label();
            this.KeyLabel5 = new System.Windows.Forms.Label();
            this.KeyLabel4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(382, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 190);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // KeyLabel1
            // 
            this.KeyLabel1.AutoSize = true;
            this.KeyLabel1.Location = new System.Drawing.Point(35, 273);
            this.KeyLabel1.Name = "KeyLabel1";
            this.KeyLabel1.Size = new System.Drawing.Size(38, 13);
            this.KeyLabel1.TabIndex = 2;
            this.KeyLabel1.Text = "Num 1";
            // 
            // KeyLabel2
            // 
            this.KeyLabel2.AutoSize = true;
            this.KeyLabel2.Location = new System.Drawing.Point(141, 273);
            this.KeyLabel2.Name = "KeyLabel2";
            this.KeyLabel2.Size = new System.Drawing.Size(38, 13);
            this.KeyLabel2.TabIndex = 3;
            this.KeyLabel2.Text = "Num 2";
            // 
            // KeyLabel3
            // 
            this.KeyLabel3.AutoSize = true;
            this.KeyLabel3.Location = new System.Drawing.Point(252, 273);
            this.KeyLabel3.Name = "KeyLabel3";
            this.KeyLabel3.Size = new System.Drawing.Size(38, 13);
            this.KeyLabel3.TabIndex = 4;
            this.KeyLabel3.Text = "Num 3";
            // 
            // KeyLabel6
            // 
            this.KeyLabel6.AutoSize = true;
            this.KeyLabel6.Location = new System.Drawing.Point(252, 64);
            this.KeyLabel6.Name = "KeyLabel6";
            this.KeyLabel6.Size = new System.Drawing.Size(38, 13);
            this.KeyLabel6.TabIndex = 7;
            this.KeyLabel6.Text = "Num 6";
            // 
            // KeyLabel5
            // 
            this.KeyLabel5.AutoSize = true;
            this.KeyLabel5.Location = new System.Drawing.Point(141, 64);
            this.KeyLabel5.Name = "KeyLabel5";
            this.KeyLabel5.Size = new System.Drawing.Size(38, 13);
            this.KeyLabel5.TabIndex = 6;
            this.KeyLabel5.Text = "Num 5";
            // 
            // KeyLabel4
            // 
            this.KeyLabel4.AutoSize = true;
            this.KeyLabel4.Location = new System.Drawing.Point(35, 64);
            this.KeyLabel4.Name = "KeyLabel4";
            this.KeyLabel4.Size = new System.Drawing.Size(38, 13);
            this.KeyLabel4.TabIndex = 5;
            this.KeyLabel4.Text = "Num 4";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(139, 32);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(220, 32);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRename
            // 
            this.buttonRename.Location = new System.Drawing.Point(301, 32);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(75, 23);
            this.buttonRename.TabIndex = 11;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "0";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Commands",
            "Windows Shorcuts",
            "Numpad"});
            this.comboBox2.Location = new System.Drawing.Point(382, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(170, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.ValueMember = "0";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Profiles";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(9, 303);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 13);
            this.labelPort.TabIndex = 14;
            this.labelPort.Text = "Port:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 328);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.KeyLabel6);
            this.Controls.Add(this.KeyLabel5);
            this.Controls.Add(this.KeyLabel4);
            this.Controls.Add(this.KeyLabel3);
            this.Controls.Add(this.KeyLabel2);
            this.Controls.Add(this.KeyLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label KeyLabel1;
        private System.Windows.Forms.Label KeyLabel2;
        private System.Windows.Forms.Label KeyLabel3;
        private System.Windows.Forms.Label KeyLabel6;
        private System.Windows.Forms.Label KeyLabel5;
        private System.Windows.Forms.Label KeyLabel4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPort;
    }
}


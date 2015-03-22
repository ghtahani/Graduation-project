namespace RemoteMontring
{
    partial class doctor
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.patient_txt = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hello Doctor ";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(265, 44);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(16, 13);
            this.ID.TabIndex = 9;
            this.ID.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "More information about the paitent";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // patient_txt
            // 
            this.patient_txt.AutoSize = true;
            this.patient_txt.Location = new System.Drawing.Point(246, 99);
            this.patient_txt.Name = "patient_txt";
            this.patient_txt.Size = new System.Drawing.Size(73, 13);
            this.patient_txt.TabIndex = 11;
            this.patient_txt.Text = "......................";
            this.patient_txt.Click += new System.EventHandler(this.label3_Click);
            // 
            // name_txt
            // 
            this.name_txt.AutoSize = true;
            this.name_txt.Location = new System.Drawing.Point(124, 44);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(0, 13);
            this.name_txt.TabIndex = 12;
            // 
            // id_txt
            // 
            this.id_txt.AutoSize = true;
            this.id_txt.Location = new System.Drawing.Point(296, 44);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(0, 13);
            this.id_txt.TabIndex = 13;
            // 
            // doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 273);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.patient_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "doctor";
            this.Text = "doctor";
            this.Load += new System.EventHandler(this.doctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label patient_txt;
        private System.Windows.Forms.Label name_txt;
        private System.Windows.Forms.Label id_txt;
    }
}
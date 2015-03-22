namespace RemoteMontring
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
            this.Agelable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.namelable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.age_txt = new System.Windows.Forms.TextBox();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.disese_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.doctor_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Agelable
            // 
            this.Agelable.AutoSize = true;
            this.Agelable.Location = new System.Drawing.Point(20, 164);
            this.Agelable.Name = "Agelable";
            this.Agelable.Size = new System.Drawing.Size(29, 13);
            this.Agelable.TabIndex = 4;
            this.Agelable.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address:";
            // 
            // namelable
            // 
            this.namelable.AutoSize = true;
            this.namelable.Location = new System.Drawing.Point(20, 80);
            this.namelable.Name = "namelable";
            this.namelable.Size = new System.Drawing.Size(38, 13);
            this.namelable.TabIndex = 6;
            this.namelable.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Disease:";
            // 
            // age_txt
            // 
            this.age_txt.Location = new System.Drawing.Point(80, 161);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(100, 20);
            this.age_txt.TabIndex = 10;
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(80, 196);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(100, 20);
            this.address_txt.TabIndex = 11;
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(80, 235);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(100, 20);
            this.phone_txt.TabIndex = 12;
            // 
            // disese_txt
            // 
            this.disese_txt.Location = new System.Drawing.Point(80, 269);
            this.disese_txt.Name = "disese_txt";
            this.disese_txt.Size = new System.Drawing.Size(100, 20);
            this.disese_txt.TabIndex = 13;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(80, 76);
            this.name_txt.Name = "name_txt";
            this.name_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name_txt.Size = new System.Drawing.Size(100, 20);
            this.name_txt.TabIndex = 9;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(80, 118);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 20);
            this.id_txt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Patient of doctor";
            // 
            // doctor_txt
            // 
            this.doctor_txt.Location = new System.Drawing.Point(188, 23);
            this.doctor_txt.Name = "doctor_txt";
            this.doctor_txt.Size = new System.Drawing.Size(100, 20);
            this.doctor_txt.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 331);
            this.Controls.Add(this.doctor_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.disese_txt);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.age_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namelable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Agelable);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Agelable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label namelable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox age_txt;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox disese_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox doctor_txt;
    }
}
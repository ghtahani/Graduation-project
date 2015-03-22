using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RemoteMontring
{
    public partial class doctor : Form
    {
        public doctor(string ss)
        {
            InitializeComponent();
            id_txt.Text = ss;
            Fillbox();
            DoctorName();
                
        }

        private void doctor_Load(object sender, EventArgs e)
        {
           
        }
        void DoctorName() {
            string DoctorName = "select * from doctor where Id='" + id_txt.Text + "';";
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\tahani\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;";
            SqlConnection conDB = new SqlConnection(constring);
            conDB.Open();
            SqlCommand quiry = new SqlCommand(DoctorName,conDB);
            SqlDataReader reader = quiry.ExecuteReader();
            if (reader.Read())
            {
                name_txt.Text = reader["Name"].ToString();
                reader.Close();

            }
        }
            private void button1_Click(object sender, EventArgs e)
        {
            if (patient_txt.Text != "......................")
            {
                Patient frm = new Patient(patient_txt.Text, id_txt.Text);
                frm.Show();
                this.Hide();
            }

                
        }

            
            void Fillbox()
            {
                string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\tahani\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;";
                string query = "select * from Patient where DID='"+id_txt.Text+"'";
                SqlConnection conDB = new SqlConnection(constring);
                SqlDataAdapter sda = new SqlDataAdapter(query,conDB);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    comboBox1.Items.Add(row["PName"].ToString());

                }

               
            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                patient_txt.Text = comboBox1.Text;
            }

            }

            

        
    }


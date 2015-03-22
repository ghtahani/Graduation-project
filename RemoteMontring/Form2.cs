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
    public partial class Form2 : Form
    {
        public Form2(string ss, string d)
        {
            InitializeComponent();
            name_txt.Text = ss;
            doctor_txt.Text = d;
            FillLaple();
        }

        void FillLaple() {
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\tahani\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;";
            string query = "select * from Patient where PName='"+ name_txt +"';";
            SqlConnection conDB = new SqlConnection(constring);
            conDB.Open();
            SqlCommand cmdDB = new SqlCommand(query, conDB);
            SqlDataReader myreader;
           
               myreader = cmdDB.ExecuteReader();
                if (myreader.Read())
                {
                    id_txt.Text = myreader.GetString(myreader.GetOrdinal("PatientID"));
                    age_txt.Text = myreader.GetString(myreader.GetOrdinal("Age"));
                    address_txt.Text = myreader["Address"].ToString();
                    phone_txt.Text = myreader["PPhone"].ToString();
                    disese_txt.Text = myreader["Disease"].ToString();

                }
           
            
          

        
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

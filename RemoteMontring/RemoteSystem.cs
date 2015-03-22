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
namespace RemoteMontring//name of project 
{
    public partial class RemoteSystem : Form
    {
        public RemoteSystem()
        {
            InitializeComponent();
            pass_txt.PasswordChar = '*';//pass_txt is name of textbox of password
        }



        private void button1_Click(object sender, EventArgs e)//this function for cancle button 
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//this function for login button
        {

            try {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\tahani\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");// place of database can defind from your database right click then copy conncetion string and replce here 
                SqlCommand quiry = new SqlCommand(" Select * From doctor where Id ='" + Id_txt.Text + "'and Password ='" + this.pass_txt.Text + "'", con);//chang id_txt and pass_txt are depand of your textbox 
              

                SqlDataReader myreader;
                con.Open();
                myreader = quiry.ExecuteReader();// 
                int count = 0;
                while (myreader.Read()) {
                    count = +1;
                }
                if (count == 1) {
                    MessageBox.Show("ID and Password are correct");
                    doctor frm = new doctor(Id_txt.Text);// depand on name of scaned form your create it.
                    frm.Show();
                }
                else if (count>1){
                    MessageBox.Show("Dublicate ID Access denide");
                }
                else
                    MessageBox.Show("Somthing wrong, Retrye to enter correct username and password");
                con.Close();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }

            
                
        }

        private void RemoteSystem_Load(object sender, EventArgs e)
        {

        }
    }
}
            
        

        
    


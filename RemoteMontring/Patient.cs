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
    public partial class Patient : Form
    {
        public Patient(string p, string d)
        {
            InitializeComponent();
            id_doc.Text = d;
           name_txt.Text = p;
           DoctorName();
            FillLabels();
           show_temp();
           // Fillbox();
           // FillData();
        }
        void DoctorName()
        {
            string DoctorName = "select * from doctor where Id='" + id_doc.Text + "';";
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\tahani\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;";
            SqlConnection conDB = new SqlConnection(constring);
            conDB.Open();
            SqlCommand quiry = new SqlCommand(DoctorName, conDB);
            SqlDataReader reader = quiry.ExecuteReader();
            if (reader.Read())
            {
                label8.Text = reader["Name"].ToString();
                reader.Close();

            }
        }
        void FillLabels()
        {
            string str;
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\tahani\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;");
            str = "select * from Patient where PName='" + name_txt.Text + "' ";
            
            con1.Open();
            SqlCommand sda = new SqlCommand(str, con1);
            SqlDataReader reader = sda.ExecuteReader();
            if (reader.Read())
            {
                
           id_txt.Text = reader["PatientID"].ToString();
                diseas_txt.Text = reader.GetString(reader.GetOrdinal("Disease"));
                address_txt.Text = reader["Address"].ToString();
                age_txt.Text = reader["Age"].ToString();
                phone_txt.Text = reader["PPhone"].ToString();
                reader.Close();
                con1.Close();
            }
        }

        void show_temp() {
            try
            {
            string DoctorName = "select * from temp_p where IDPatient='" + id_txt.Text + "';";
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\tahani\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;";
            SqlConnection conDB = new SqlConnection(constring);
            SqlCommand quiry = new SqlCommand(DoctorName, conDB);
            
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = quiry;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

            void Fillbox()
            {
                string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\tahani\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;";
                string query = "select * from Patient;";
                SqlConnection conDB = new SqlConnection(constring);
                SqlCommand cmdDB = new SqlCommand(query, conDB);
                SqlDataReader myreader;
                try
                {
                    conDB.Open();
                    myreader = cmdDB.ExecuteReader();
                    while (myreader.Read())
                    {
                        string pname = myreader.GetString(myreader.GetOrdinal("Name"));

                      //  comboBox1.Items.Add(pname);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



        void FillData()
        {
            // 1
            // Open connection
            using (SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\tahani\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;"))
            {
                c.Open();
                // 2
                // Create new DataAdapter
                try
                {
                    using (SqlDataAdapter a = new SqlDataAdapter(
                        "select * from [Table] where IDPatient='" + id_txt.Text + "';", c))
                    {
                        // 3
                        // Use DataAdapter to fill DataTable
                        DataTable t = new DataTable();
                        a.Fill(t);
                        // 4
                        // Render data onto the screen
                        dataGridView1.DataSource = t;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet2.Table' table. You can move, or remove it, as needed.
           // this.tableTableAdapter.Fill(this.dataDataSet2.Table);
            // TODO: This line of code loads data into the 'dataDataSet1.temp_p' table. You can move, or remove it, as needed.
            this.temp_pTableAdapter.Fill(this.dataDataSet1.temp_p);

           
            // TODO: This line of code loads data into the 'dataDataSet.Temprture' table. You can move, or remove it, as needed.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void temprtureBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

    }
}

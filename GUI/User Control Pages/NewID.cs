using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QRCoder;

namespace ID_CARD_GENERATOR_AND_AUTHENTICATION_SYSTEM
{

    public partial class NewID : UserControl
    {

        private DataAccess da;
        private SqlConnection sqlcon;

        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
        public static string SetValueForText6 = "";
        public static string SetValueForText7 = "";
        public static Image photo;
        public static Image QRCode;

        private static readonly Random random = new Random();
        int id = random.Next(100, 999);


        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }

        Card card = new Card();
        private void DataPass()
        {
            SetValueForText1 = firstName.Text;
            SetValueForText2 = lastName.Text;
            SetValueForText3 = dob.Text;
            SetValueForText4 = fathersName.Text;
            SetValueForText5 = comboBox1.SelectedItem.ToString();
            SetValueForText6 = AutoGenID();
            SetValueForText7 = contact.Text;
            photo = pictureBox1.Image;

            GenerateQR();

            if(card.IsDisposed == true)
            {
                card = new Card();
            }
            
            card.Show();

        }

        private void GenerateQR()
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(AutoGenID(), QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);

            QRCode = code.GetGraphic(5);

        }


        private string AutoGenID()
        {

            string ID = "AB-" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "-" + id;
            return ID;
        }

        public NewID()
        {
            InitializeComponent();
            this.Da = new DataAccess();

        }

        private void ImageTransfer()
        {
             
        }

        private void NewID_Load(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {


            try
            {
                if (this.male.Checked)
                {

                    string sql = @"insert into regData
                        values ('" + this.AutoGenID() + "', '" + this.firstName.Text + "', '" + this.lastName.Text + "', '" + this.dob.Text + "','" +
                            this.fathersName.Text + "', '" + this.male.Text + "', '" + this.comboBox1.SelectedItem + "', '" + this.contact.Text + "');";


                    if(string.IsNullOrEmpty(firstName.Text) || string.IsNullOrEmpty(lastName.Text) || string.IsNullOrEmpty(dob.Text) || 
                        string.IsNullOrEmpty(fathersName.Text) || string.IsNullOrEmpty(contact.Text))
                    {
                        MessageBox.Show("Please Fill all the information or Try Again");
                    }
                    else
                    {
                        this.Da.ExecuteUpdateQuery(sql);

                        MessageBox.Show("Registration Complete.");

                        DataPass();
                    }
                    


                }
                else if (this.female.Checked)
                {

                    int id = random.Next(100, 999);

                    string sql = @"insert into regData
                        values ('" + this.AutoGenID() + "', '" + this.firstName.Text + "', '" + this.lastName.Text + "', '" + this.dob.Text + "','" +
                            this.fathersName.Text + "', '" + this.female.Text + "', '" + this.comboBox1.SelectedItem + "', '" + this.contact.Text + "');";

                    if (string.IsNullOrEmpty(firstName.Text) || string.IsNullOrEmpty(lastName.Text) || string.IsNullOrEmpty(dob.Text) ||
                            string.IsNullOrEmpty(fathersName.Text) || string.IsNullOrEmpty(contact.Text))
                    {
                        MessageBox.Show("Fill all the information or Please Try Again later.");
                    }
                    else
                    {
                        this.Da.ExecuteUpdateQuery(sql);

                        MessageBox.Show("Registration Complete.");

                        DataPass();
                    }


                    //da.Sqlcon.Close();
                }
                else
                {

                    int id = random.Next(100, 999);

                    string sql = @"insert into regData
                        values ('" + this.AutoGenID() + "', '" + this.firstName.Text + "', '" + this.lastName.Text + "', '" + this.dob.Text + "','" +
                           this.fathersName.Text + "', '" + this.other.Text + "', '" + this.comboBox1.SelectedItem + "', '" + this.contact.Text + "');";

                    if (string.IsNullOrEmpty(firstName.Text) || string.IsNullOrEmpty(lastName.Text) || string.IsNullOrEmpty(dob.Text) ||
                        string.IsNullOrEmpty(fathersName.Text) || string.IsNullOrEmpty(contact.Text))
                    {
                        MessageBox.Show("Fill all the information or Please Try Again later.");
                    }
                    else
                    {
                        this.Da.ExecuteUpdateQuery(sql);

                        MessageBox.Show("Registration Complete.");

                        DataPass();
                    }

                }

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "jpg|*.jpg";

            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

            }


        }
    }
}

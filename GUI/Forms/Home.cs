using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;


namespace ID_CARD_GENERATOR_AND_AUTHENTICATION_SYSTEM
{
    public partial class Home : MaterialSkin.Controls.MaterialForm //Form
    {


        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }

        public Home()
        {
            InitializeComponent();

            this.Da = new DataAccess();

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void Home_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboDevice.Items.Add(filterInfo.Name); // A list of available camera device connected with the computer
            cboDevice.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString); 
            captureDevice.NewFrame += captureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start(); // Starting the camera for scanning any QR (quick response) code.
        }

        private void captureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    txtQRCode.Text = result.ToString();

                    timer1.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop(); // after scanning and decoding the code from QR the cam view freezes.
                        Authenticate();
                    }

                }

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }


        private void DataFetch()
        {

            // Fetching the data from the Registration Data table of the database

            SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=AAC;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select firstname,lastname from regData where id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", txtQRCode.Text);
            SqlDataReader da = cmd.ExecuteReader();

            while(da.Read())
            {
                firstName.Text = da.GetValue(0).ToString(); 
                lastName.Text = da.GetValue(1).ToString();
            }
            con.Close();
        }

        
        private void Log()
        {
            DateTime now = DateTime.Now;  // For tracking the current date and time during a successfull scan

            string name = (this.firstName.Text +  " " + this.lastName.Text);

            string sql = @"insert into log 
                        values ('" + this.txtQRCode.Text + "', '" + name + "', '" + now.ToString() + "');";  // inserting into the Log table in the Database


            this.Da.ExecuteUpdateQuery(sql);
 
        }

        private void Authenticate()
        {
           
            SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=AAC;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select Count (*) from regData where id = '" + txtQRCode.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            try
            {
                if (dt.Rows[0][0].ToString() == "1") 
                {
                    status.BackColor = Color.Green;
                    status.Text = "VALID";
                    DataFetch();
                    Log();

                }
                else
                {
                    status.BackColor = Color.Red;
                    status.Text = "INVALID";
                    //MessageBox.Show("Please Try Again");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtQRCode_Click(object sender, EventArgs e)
        {

        }

        private void firstName_Click(object sender, EventArgs e)
        {

        }
    }
}

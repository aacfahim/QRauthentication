using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID_CARD_GENERATOR_AND_AUTHENTICATION_SYSTEM
{
    public partial class Dashboard : MaterialSkin.Controls.MaterialForm //Form
    {
        
        public void DesignForm()
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }
        
        public Dashboard()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newID1.Show();
            search1.Hide();
            about1.Hide();
            adminSettings1.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            newID1.Hide();
            search1.Show();
            about1.Hide();
            adminSettings1.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            newID1.Hide();
            search1.Hide();
            about1.Show();
            adminSettings1.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            newID1.Hide();
            search1.Show();
            about1.Hide();
            adminSettings1.Hide();



        }

        private void search1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminSettings1.Show();
            newID1.Hide();
            search1.Hide();
            about1.Hide();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID_CARD_GENERATOR_AND_AUTHENTICATION_SYSTEM
{
    public partial class AdminSettings : UserControl
    {
        public AdminSettings()
        {
            InitializeComponent();
            comboBox1.Items.Insert(0, "Light");
            comboBox1.Items.Insert(1, "Dark");
            comboBox1.SelectedIndex = 0;

        }

        private void SaveTheme_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            Dashboard dashboard = new Dashboard();
            Home home = new Home();

            if (comboBox1.SelectedItem.ToString() == "Dark")
            {
                MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
                skinManager.AddFormToManage(login);
                skinManager.AddFormToManage(home);
                skinManager.AddFormToManage(dashboard);
                skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
                skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

                dashboard.Hide();
                dashboard.Show();


            }
            else if (comboBox1.SelectedItem.ToString() == "Light")
            {
                MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
                skinManager.AddFormToManage(login);
                skinManager.AddFormToManage(home);
                skinManager.AddFormToManage(dashboard);
                skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
                skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);


                dashboard.Hide();
                dashboard.Show();

            }
            else if(comboBox1.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Please choose a Theme");
            }


            
        }
    }
}

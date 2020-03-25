using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ID_CARD_GENERATOR_AND_AUTHENTICATION_SYSTEM.GUI.Forms;
using System.Data.SqlClient;

namespace ID_CARD_GENERATOR_AND_AUTHENTICATION_SYSTEM
{
    public partial class Search : UserControl
    {

        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }

        Log log = new Log();


        public Search()
        {
            InitializeComponent();

            this.Da = new DataAccess();

            this.PopulateGridView();
        }


        //For generating Scanning log from database

        private void PopulateLogGridView(string sql = "select * from log;") 
        {
            log.LogdataGridView.AutoGenerateColumns = false;

            this.Ds = this.Da.ExecuteQuery(sql);
            log.LogdataGridView.DataSource = this.Ds.Tables[0];
        }


        // for generating user infomation from database
        private void PopulateGridView(string sql = "select * from regData;")
        {
            this.dgvMain.AutoGenerateColumns = false;

            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvMain.DataSource = this.Ds.Tables[0];
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
        }



        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            //string sql = "select * from regData where contact like'" + this.txtAutoSearch.Text + "%';";

            string sql = "select * from regData where contact like '" + this.txtAutoSearch.Text + "%' or id like '" + 
                this.txtAutoSearch.Text + "%'";

            this.PopulateGridView(sql);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

            /*Checking the data from table*/

            string sql = "select * from log where id like '" + this.textBox1.Text + "%';";
            this.PopulateLogGridView(sql);


            if (textBox1.Text.Contains("AB"))
            {
                
                if(log.IsDisposed == true)
                {
                    log = new Log();
                }

                log.Show();
                this.PopulateLogGridView(sql);
                
            }
            else
            {
                MessageBox.Show("Please enter a valid ID");
            }




        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ID = this.dgvMain.CurrentRow.Cells["id"].Value.ToString();
            string name = this.dgvMain.CurrentRow.Cells["firstname"].Value.ToString();
            string sql = "delete from regData where id = '" + ID + "';";
            this.Da.ExecuteUpdateQuery(sql);
            MessageBox.Show(name + " has been Banned.");
            this.PopulateGridView();
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {

            // Showing ALL Logs

            if (log.IsDisposed == true)
            {
                log = new Log();
            }

            log.Show();

            string sql = "select * from log;";

            this.PopulateLogGridView(sql);
        }
    }
}

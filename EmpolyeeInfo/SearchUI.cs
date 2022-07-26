using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpolyeeInfo
{
    public partial class SearchUI : Form
    {
        public SearchUI()
        {
            InitializeComponent();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            string name = NametextBox.Text;
            string conString = "Data Source=DESKTOP-1ACAIOK; Database=EmpolyeeBD; Integrated Security=SSPI;";
            SqlConnection aConnection = new SqlConnection(conString);
            
            string query = "  SELECT * FROM [EmpolyeeBD].[dbo].[Table_Employee] WHERE name = '"+name+"';";
            SqlCommand aCommand = new SqlCommand();
            aCommand.CommandText = query;
            aCommand.Connection = aConnection;
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            while(aReader.Read())
            {
                if (aReader.HasRows)
                {
                    Emaillabel.Text = aReader["email"].ToString();
                    ContactNolabel.Text = aReader["contactNo"].ToString();
                    BloodGrouplabel.Text = aReader["bloodGroup"].ToString();
                    Addresslabel.Text = aReader["address"].ToString();

                }
                else
                {
                    MessageBox.Show("No Data");
                }
            }
            aReader.Close();
            aConnection.Close();
        }

      
    }
}

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

namespace EmpolyeeInfo
{
    public partial class SaveUI : Form
    {
        public SaveUI()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            Empolyee aEmpolyee = new Empolyee();

            aEmpolyee.name = NametextBox.Text;
            aEmpolyee.email = EmailtextBox.Text;
            aEmpolyee.contactNo = ContactNotextBox.Text;
            aEmpolyee.bloodGroup = BloodGroupcomboBox.Text;
            aEmpolyee.address = AddresstextBox.Text;

            string conString = "Data Source=DESKTOP-1ACAIOK; Database=EmpolyeeBD; Integrated Security=SSPI;";
            SqlConnection aConnection = new SqlConnection(conString);
            aConnection.Open();

            string query = "Insert INTO Table_Employee values('" +aEmpolyee.name+ "','" +aEmpolyee.email +"','" +aEmpolyee.contactNo+ "','" +aEmpolyee.bloodGroup+ "','" +aEmpolyee.address+ "')";
            SqlCommand aCommand = new SqlCommand();
            aCommand.Connection = aConnection;
            aCommand.CommandText = query;
            aCommand.ExecuteNonQuery();
            aConnection.Close();
            ClearAllControls();
            MessageBox.Show("Empolyee Added");
        }

        private void ClearAllControls()
        {
            NametextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            ContactNotextBox.Text = string.Empty;
            BloodGroupcomboBox.Text = string.Empty;
            AddresstextBox.Text = string.Empty;
            
        }
    }
}

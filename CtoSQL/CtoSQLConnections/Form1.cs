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

namespace CtoSQLConnections
{
    public partial class resultTB : Form
    {
        const string connString = @"Server=PL6\MTCDB;Database=AdventureWorks2012;Trusted_Connection=True;";
        SqlConnection sqlConn = new SqlConnection(connString);

        public resultTB()
        {
            InitializeComponent();
        }

        private void customersCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboObject currentObject = (cboObject)customersCB.SelectedItem;
            int CustomerID = currentObject.CustomerID;
            DataTable salesOrdersDT = new DataTable();

            try
            {
                SqlCommand sqlComm = new SqlCommand("spSalesOrderDts", sqlConn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlParameter prmCustomerID = new SqlParameter("@CustomerID", CustomerID);
                sqlComm.Parameters.Add(prmCustomerID);

                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlComm);

                sqlDa.Fill(salesOrdersDT);

                salesOrdersDG.DataSource = salesOrdersDT;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("spActiveCustomers", sqlConn);
            DataTable CustomersDT = new DataTable();
            int CustomerID;
            string CustomerName;

            try
            {
                sqlDa.Fill(CustomersDT);

                foreach (DataRow drCustomer in CustomersDT.Rows)
                {
                    CustomerID = int.Parse(drCustomer.ItemArray[0].ToString());
                    CustomerName = drCustomer.ItemArray[1].ToString();
                    customersCB.Items.Add(new cboObject(CustomerID, CustomerName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }

        private void salesOrdersDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Checks if the row has any values.
            if (e.RowIndex >=0)
            {
                // Makes a collection of all rows.
                DataGridViewRow Row = this.salesOrdersDG.Rows[e.RowIndex];

                // Makes it so wherever you click into the grid,
                // it populates with the sales order id.
                ResultLabel.Text = Row.Cells[0].Value.ToString();
            }
        }
    }

    public class cboObject
    {
        int cID;
        string cName;

        public cboObject(int CustomerID, string CustomerName)
        {
            cID = CustomerID;
            cName = CustomerName;
        }

        public string CustomerName
        {
            get { return cName; }
            set { cName = value; }
        }

        public int CustomerID
        {
            get { return cID; }
            set { cID = value; }
        }

        public override string ToString()
        {
            return this.CustomerName;
        }
    }
}


using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageDatabaseView
{
    public partial class Form1 : Form
    {
        private OleDbDataAdapter adapter = new OleDbDataAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            accessDataGridView.RowTemplate.Height = 100;
            accessDataGridView.DataSource = accessBindingSource;
            LoadData();
        }

        /// <summary>
        /// Sets up the connection and loads our initial data from the database
        /// </summary>
        private void LoadData()
        {
            // Binding code taken from here: https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-bind-data-to-the-windows-forms-datagridview-control
            var connectionString = ConfigurationManager.ConnectionStrings["AccessDB"].ConnectionString;

            var dataSet = new DataSet();

            // Query taken from example here: https://stackoverflow.com/questions/28786440/c-sharp-read-attachments-from-access-accdb
            // "Image" is the Attachment field name in my sample AccessDB file
            using (var connection = new OleDbConnection(connectionString))
            using (var command = new OleDbCommand("SELECT ID, Description, Image.FileName, Image.FileData FROM Images", connection))
            {
                adapter = new OleDbDataAdapter(command);
                adapter.Fill(dataSet);
            }

            accessBindingSource.DataSource = dataSet.Tables[0];

            accessDataGridView.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        /// <summary>
        /// Event called for each value passed into the data grid view.  
        /// Allows us to override values or change types.
        /// </summary>
        /// <param name="sender">The DataGridView this event was raised by.</param>
        /// <param name="e">Details on the cell being populated</param>
        private void accessDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Image column with unformatted byte array
            if (e.ColumnIndex == 3 && e.Value is byte[])
            {
                var bytes = ((byte[])e.Value).Skip(20).ToArray();

                // Convert byte array attachment into an actual image
                using (var ms = new MemoryStream(bytes))
                {
                    e.Value = new Bitmap(ms);
                }
            }
        }
    }
}

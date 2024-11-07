using Newtonsoft.Json;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.Input.Enums;
using System.Globalization;
using WinFormsAppTestSynfusion.Data;

namespace WinFormsAppTestSynfusion
{
    public partial class TruckForm : Form
    {
        public TruckForm()
        {
            InitializeComponent();
            this.sfDataGrid1.Width = 600;
            this.sfDataGrid1.Columns.Add(new GridDateTimeColumn()
            {
                MappingName = "CreatedDate",
                HeaderText = "Created Date",
                Width = 150
            });
            this.sfDataGrid1.Columns["CreatedDate"].Format = "dd/mm/yyyy";
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "VehicleRegNo",
                HeaderText = "VehicleReg No",
                Width = 150
            });
            NumberFormatInfo numberFormat = Application.CurrentCulture.NumberFormat.Clone() as NumberFormatInfo;
            numberFormat.NumberDecimalDigits = 2;
            this.sfDataGrid1.Columns.Add(new GridNumericColumn()
            {
                MappingName = "UnladenWeight",
                HeaderText = "Unladen Weight",
                FormatMode = FormatMode.Numeric,
                NumberFormatInfo = numberFormat,
                Width = 150
            });
            this.sfDataGrid1.Columns.Add(new GridCheckBoxColumn()
            {
                MappingName = "Active",
                HeaderText = "Active",
                Width = 150
            });

            //Change the record cell back color for product name column.
            this.sfDataGrid1.Columns["CreatedDate"].CellStyle.BackColor = Color.SlateGray;

            //Change the record cell text color for product name column.
            this.sfDataGrid1.Columns["CreatedDate"].CellStyle.TextColor = Color.White;

            //Change the header cell back color for product name column.
            this.sfDataGrid1.Columns["CreatedDate"].HeaderStyle.BackColor = Color.MediumSlateBlue;

            //Change the header cell text color for product name column.
            this.sfDataGrid1.Columns["CreatedDate"].HeaderStyle.TextColor = Color.White;
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            List<Truck> truckList = new List<Truck>();
            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromMinutes(5);
            string active = "true";
            HttpResponseMessage json = await client.GetAsync("http://192.168.0.104:45457/api/TruckData/GetTruckList/?active=" + active);
            if (json.IsSuccessStatusCode)
            {

                string content = await json.Content.ReadAsStringAsync();
                truckList = JsonConvert.DeserializeObject<List<Truck>>(content);
            }
            sfDataGrid1.DataSource = truckList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}

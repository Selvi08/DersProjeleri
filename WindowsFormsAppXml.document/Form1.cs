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
using System.Xml;
using System.Xml.Linq;
using Xamarin.Essentials;

namespace WindowsFormsAppXml.document
{
    public partial class Form1 : Form
    {
        private object Latitude;

        public object CountryName { get; private set; }
        public object Tilt { get; private set; }
        public object PlateCode { get; private set; }
        public object Heading { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog


            {

                //This doesn't work

                InitialDirectory = @"D:\",
                Title = "City Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // textBox1.Text = openFileDialog1.FileName;
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable { TableName = "cityTable" };
            {
                var T_name = new DataColumn("T_name", typeof(string)) { AllowDBNull = true };
                var name = new DataColumn("name", typeof(string)) { AllowDBNull = true };
                var visibility = new DataColumn("visibility", typeof(string)) { AllowDBNull = true };
                var longitude = new DataColumn("longitude", typeof(string)) { AllowDBNull = true };
                var latitude = new DataColumn("latitude", typeof(string)) { AllowDBNull = true };
                var altitude = new DataColumn("altitude", typeof(string)) { AllowDBNull = true };
                var heading = new DataColumn("heading", typeof(string)) { AllowDBNull = true };
                var tilt = new DataColumn("tilt", typeof(string)) { AllowDBNull = true };
                var range = new DataColumn("range", typeof(string)) { AllowDBNull = true };
                var coordinates = new DataColumn("coordinates", typeof(string)) { AllowDBNull = true };
                var platecode = new DataColumn("platecode", typeof(string)) { AllowDBNull = true };
                var link = new DataColumn("link", typeof(string)) { AllowDBNull = true };



                dt.Columns.Add(T_name);
                dt.Columns.Add(name);
                dt.Columns.Add(visibility);
                dt.Columns.Add(longitude);
                dt.Columns.Add(latitude);
                dt.Columns.Add(altitude);
                dt.Columns.Add(heading);
                dt.Columns.Add(tilt);
                dt.Columns.Add(range);
                dt.Columns.Add(coordinates);
                dt.Columns.Add(platecode);
                dt.Columns.Add(link);

                return;

            }

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com/kml/ext/2.2");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 11;
            dataGridView1.Columns[0].Name = "Country Name";
            dataGridView1.Columns[1].Name = "City Name";
            dataGridView1.Columns[2].Name = "longitude";
            dataGridView1.Columns[3].Name = "latitude";
            dataGridView1.Columns[4].Name = "altitude";
            dataGridView1.Columns[5].Name = "heading";
            dataGridView1.Columns[6].Name = "Tilt";
            dataGridView1.Columns[7].Name = "Range";
            dataGridView1.Columns[8].Name = "coordinates";
            dataGridView1.Columns[9].Name = "plate code";
            dataGridView1.Columns[10].Name = "Link";

            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = "Türkiye";
            row.Cells[1].Value = "Malatya";
            row.Cells[2].Value = "38°15'52.57'D";
            row.Cells[3].Value = "38°14'51.23'K";
            row.Cells[4].Value = "840m";
            row.Cells[5].Value = "840";
            row.Cells[6].Value = "45.000000°";
            row.Cells[7].Value = "141688m";
            row.Cells[8].Value = "35.243322,38.963745,0";
            row.Cells[9].Value = "44";
            row.Cells[10].Value = "https://www.google.com/maps?ll=38.24795,38.26460&z=9&t=h";


            dataGridView1.Rows.Add(row);

            //dataGridView1.Rows.Add("Türkiye");
            //dataGridView1.Rows.Add("Malatya");
            //dataGridView1.Rows.Add("38°15'52.57'D");
            //dataGridView1.Rows.Add(" 38°14'51.23'K");
            //dataGridView1.Rows.Add("840m");
            //dataGridView1.Rows.Add("915950");
            //dataGridView1.Rows.Add("45.000000°");
            //dataGridView1.Rows.Add("141688m");

            DataGridViewRow row2 = (DataGridViewRow)dataGridView1.Rows[1].Clone();
            row2.Cells[0].Value = "Türkiye";
            row2.Cells[1].Value = "Şanlıurfa";
            row2.Cells[2].Value = "38°47'43.85'D";
            row2.Cells[3].Value = "37°10'2.65'K";
            row2.Cells[4].Value = "547m";
            row2.Cells[5].Value = "545";
            row2.Cells[6].Value = "29845m°";
            row2.Cells[7].Value = "29845m";
            row2.Cells[8].Value = "38.7955149,37.1674039,0";
            row2.Cells[9].Value = "63";
            row2.Cells[10].Value = "https://www.google.com/maps/@37.1674,38.79551,38087m/data=!3m1!1e3";

            dataGridView1.Rows.Add(row2);

            DataGridViewRow row3 = (DataGridViewRow)dataGridView1.Rows[2].Clone();
            row3.Cells[0].Value = "Türkiye";
            row3.Cells[1].Value = "Gaziantep";
            row3.Cells[2].Value = "37°22'41.20'D";
            row3.Cells[3].Value = "37°3'57.43'K";
            row3.Cells[4].Value = "840m";
            row3.Cells[5].Value = "840";
            row3.Cells[6].Value = "29845m";
            row3.Cells[7].Value = "14961m";
            row3.Cells[8].Value = "37.37811,37.065953,0";
            row3.Cells[9].Value = "27";
            row3.Cells[10].Value = "https://www.google.com/maps/@37.06595,37.37811,19069m/data=!3m1!1e3";

            dataGridView1.Rows.Add(row3);

            DataGridViewRow row4 = (DataGridViewRow)dataGridView1.Rows[3].Clone();
            row4.Cells[0].Value = "Türkiye";
            row4.Cells[1].Value = "Adıyaman";
            row4.Cells[2].Value = "38°16'38.13'D";
            row4.Cells[3].Value = "37°45'49.14'K";
            row4.Cells[4].Value = "669m";
            row4.Cells[5].Value = "650";
            row4.Cells[6].Value = "2887m";
            row4.Cells[7].Value = "3880m";
            row4.Cells[8].Value = "38.2772592,37.76365,0";
            row4.Cells[9].Value = "02";
            row4.Cells[10].Value = "https://www.google.com/maps/@37.76303,38.27551,4723m/data=!3m1!1e3";

            dataGridView1.Rows.Add(row4);

            DataGridViewRow row5 = (DataGridViewRow)dataGridView1.Rows[4].Clone();
            row5.Cells[0].Value = "Türkiye";
            row5.Cells[1].Value = "Samsun";
            row5.Cells[2].Value = "36°20'9.84'D";
            row5.Cells[3].Value = "41°16'46.93'K";
            row5.Cells[4].Value = "44m";
            row5.Cells[5].Value = "45m";
            row5.Cells[6].Value = "05.01";
            row5.Cells[7].Value = "29501m";
            row5.Cells[8].Value = "41.279745";
            row5.Cells[9].Value = "55";
            row5.Cells[10].Value = "https://www.google.com/maps/@41.2797,36.33607,35919m/data=!3m1!1e3";

            dataGridView1.Rows.Add(row5);



            XmlDocument doc = new XmlDocument();
            doc.Load("C://temp.xml");

            XmlNode node = doc.DocumentElement.SelectSingleNode("//city");
            string text = node.InnerText;


            using (SqlConnection connection = new SqlConnection("ConnectionStringHere"))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;            
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into tbl_city (CountryName, CityName, Longitude, Latitude, Altitude, Heading, Tilt, Coordinates, Plate Code, Link) VALUES (@CountryName, @CityName, @Longitude, @Latitude, @Altitude, @Heading, @Tilt, @Range., @Coordinates, @Plate Code, @Link)";
                    command.Parameters.AddWithValue("@CountryName", CountryName);
                    command.Parameters.AddWithValue("@CityName", Tilt);
                    command.Parameters.AddWithValue("@Latitude", Latitude);
                    command.Parameters.AddWithValue("@Altitude", PlateCode);
                    command.Parameters.AddWithValue("@Heading", Heading);
                    command.Parameters.AddWithValue("@Tilt", Tilt);
                    command.Parameters.AddWithValue("@Coordinates", Latitude);
                    command.Parameters.AddWithValue("@PlateCode", PlateCode);




                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        // error here
                    }
                    finally
                    {
                        connection.Close();
                    }
                }


            }















        }


    }

}
    


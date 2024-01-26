using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NesneProje
{
    public partial class GrafikEkrani : Form
    {
        public GrafikEkrani()
        {
            InitializeComponent();
        }

        private void GrafikEkrani_Load(object sender, EventArgs e)
        {
            DrawChart(SeriesChartType.Column);
            DrawChart_Yas(SeriesChartType.Line);
        }

        //Cinsiyet Grafiği İçin
        private void DrawChart(SeriesChartType chartType)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\GÜRKAN ŞAHİN\Documents\SporDb.mdf"";Integrated Security=True;Connect Timeout=30");
            DataTable dt = new DataTable();

            try
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT 'Bay' AS Cinsiyet, COUNT(*) AS Sayisi FROM UyeTbl WHERE Ucinsiyet = 'Bay'\r\nUNION ALL\r\nSELECT 'Bayan' AS Cinsiyet, COUNT(*) AS Sayisi FROM UyeTbl WHERE Ucinsiyet = 'Bayan';\r\n", connection);
                adapter.Fill(dt);

                chart1.Series.Clear();
                chart1.Series.Add("Cinsiyet");
                chart1.Series["Cinsiyet"].XValueMember = "Cinsiyet";
                chart1.Series["Cinsiyet"].YValueMembers = "Sayisi";
                chart1.DataSource = dt;

                // Set the chart type based on the selected button
                chart1.Series["Cinsiyet"].ChartType = chartType;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        //Yaş Oran Grafiği için
        private void DrawChart_Yas(SeriesChartType chartType)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\GÜRKAN ŞAHİN\Documents\SporDb.mdf"";Integrated Security=True;Connect Timeout=30");
            DataTable dt = new DataTable();

            try
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT UYas AS Yas, COUNT(*) AS Sayisi FROM UyeTbl GROUP BY Uyas;", connection);
                adapter.Fill(dt);

                chart2.Series.Clear();
                chart2.Series.Add("Yas");
                chart2.Series["Yas"].XValueMember = "Yas";
                chart2.Series["Yas"].YValueMembers = "Sayisi";
                chart2.DataSource = dt;

                // Set the chart type based on the selected button
                chart2.Series["Yas"].ChartType = chartType;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DrawChart(SeriesChartType.Column);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DrawChart(SeriesChartType.Pie);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DrawChart(SeriesChartType.Line);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Column Button
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            DrawChart_Yas(SeriesChartType.Column);

        }

        //Pie Button
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DrawChart_Yas(SeriesChartType.Pie);
        }
        //Line button

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DrawChart_Yas(SeriesChartType.StepLine);
        }
        //Geri button

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UyeleriGoruntule gor = new UyeleriGoruntule();
                gor.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

        }
    }
}

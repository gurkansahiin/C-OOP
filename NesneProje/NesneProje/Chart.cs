using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace NesneProje
{
    public class Chart
    {
        private SqlConnection connection;
        private Chart chart;

        public Chart(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        public Chart ChartInstance
        {
            get { return chart; }
            set { chart = value; }
        }

        public void DrawChart(SeriesChartType chartType, string seriesName, string xValueMember, string yValueMember)
        {
            if (chart == null)
            {
                MessageBox.Show("Chart nesnesi atanmamış.");
                return;
            }

            DataTable dt = new DataTable();

            try
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT 'Bay' AS Cinsiyet, COUNT(*) AS Sayisi FROM UyeTbl WHERE Ucinsiyet = 'Bay'\r\nUNION ALL\r\nSELECT 'Bayan' AS Cinsiyet, COUNT(*) AS Sayisi FROM UyeTbl WHERE Ucinsiyet = 'Bayan';\r\n", connection);
                adapter.Fill(dt);

                //chart.Series.Clear();
                //chart.Series.Add(seriesName);
                //chart.Series[seriesName].Points.DataBind(dt.AsEnumerable(), xValueMember, yValueMember, "");

                //// Set the chart type based on the selected button
                //chart.Series[seriesName].ChartType = chartType;
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
    }
}

using Microsoft.Data.Sqlite;
using System;
using System.Windows;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }
        class Items
        {
            public double cyl_dia, cyl_len, density, parts, volume, weight, totalweight, costperunit, totalcost;

            public Items(double cyl_dia, double cyl_len, double density, double parts, double costperunit)
            {
                volume = 3.14 / 4 * cyl_dia * cyl_dia * cyl_len;
                weight = density * volume;
                totalweight = parts * weight;
                totalcost = costperunit * totalweight;
            }

            //void Calculations()
            //{
            //    volume = 3.14 / 4 * cyl_dia * cyl_dia * cyl_len;
            //    weight = density * volume;
            //    totalweight = parts * weight;
            //    totalcost = costperunit * totalweight;
            //}
        }


        public double costperunit1, parts1, density_1, density_2, density_3, cost_1, cost_2, cost_3, cyl_dia, cyl_len;

        //public double parts1, volume1, weight1, totalwight1, costperunit1, totalcost1;
        
        private void btn_part1_Click(object sender, RoutedEventArgs e)
        {

            cyl_len = Convert.ToDouble(txt_cylinder_len.Text);
            cyl_dia = Convert.ToDouble(txt_cylinder_dia.Text);
            parts1 = Convert.ToDouble(txt_part1_no.Text);

            if (cmb_mtl_1.SelectedIndex == 0)
            {
                density_1 = 8830;
                costperunit1 = 10;
            }

            else if (cmb_mtl_1.SelectedIndex == 1)
            {
                density_1 = 2710;
                costperunit1 = 76;


            }

            else if (cmb_mtl_1.SelectedIndex == 2)
            {
                density_1 = 7150;
                costperunit1 = 45;

            }

            else if (cmb_mtl_1.SelectedIndex == 3)
            {
                density_1 = 8030;
                costperunit1 = 43;

            }

            Items part1 = new Items(cyl_dia, cyl_len, density_1, parts1, costperunit1);

            //Volume
            //volume1 = 3.14 / 4 * cyl_dia * cyl_dia * cyl_len;

            ////Wieght 
            //weight1 = density_1 * volume1;
            //totalwight1 = weight1 * parts1;

            //totalcost1 = totalwight1 * costperunit1;

            txt_part1_volume.Text = part1.volume.ToString();
            txt_part1_total_weight.Text = part1.totalweight.ToString();
            txt_part1_costperunit.Text = part1.costperunit.ToString();
            txt_part1_totalcost.Text = part1.totalcost.ToString();


            //using (SqliteConnection conn = new SqliteConnection(@"Data Source=C:\Users\Opa\source\repos\WpfApp1\bin\Debug\DataBase.db;"))
            //{
            //    conn.Open();

            //    SqliteCommand command = new SqliteCommand("Insert INTO Material ('Volume') VALUES ('" + part1.volume + "')", conn);
            //    SqliteCommand command1 = new SqliteCommand("Insert INTO Material ('Weight_Set_1') VALUES ('" + part1.totalweight + "')", conn);
            //    SqliteCommand command2 = new SqliteCommand("Insert INTO Material ('Total_Material_Cost_1') VALUES ('" + part1.totalcost + "')", conn);

            //    SqliteDataReader reader = command.ExecuteReader();
            //    SqliteDataReader reader1 = command1.ExecuteReader();
            //    SqliteDataReader reader2 = command2.ExecuteReader();
        }
    }
}

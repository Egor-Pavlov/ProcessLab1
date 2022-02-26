using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessLab1
{
    public partial class Form1 : Form
    {
        List<double> U = new List<double>();
        List<double> V = new List<double>();
        public Form1()
        {
            InitializeComponent();
            NormDistr u = new NormDistr(1, 3, 10);
            u.GenerateSelection();
            NormDistr v = new NormDistr(2, 4, 10);
            v.GenerateSelection();
            U = u.GetSelection();
            V = v.GetSelection();
        }
        bool CheckInpit()
        {
            try
            {
                double MU = Convert.ToDouble(MUTB.Text);
                double DU = Convert.ToDouble(DUTB.Text);
                double MV = Convert.ToDouble(MVTB.Text);
                double DV = Convert.ToDouble(DVTB.Text);

                if (DU <= 0 || DV <= 0)
                {
                    MessageBox.Show("Дисперсия не может быть меньше 1.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
                int p = Convert.ToInt32(PointsCountTB.Text);
                if(p <= 0)
                {
                    MessageBox.Show("Количество точек не может быть меньше 1.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                int N = Convert.ToInt32(NTB.Text);
                if (N <= 0)
                {
                    MessageBox.Show("Число реализаций не может быть меньше 1.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                double min = Convert.ToDouble(minTB.Text);
                double max = Convert.ToDouble(maxTB.Text);
                if(min == max)
                {
                    MessageBox.Show("Минимальное и максимальное значение t не могут быть равны.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (min > max)
                {
                    MessageBox.Show("Минимальное значение t не может быть больше максимального.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Попробуйте проверить корректность ввода данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void Start_Click_1(object sender, EventArgs e)
        {
            if (!CheckInpit())
                return;
            //получаем нормально распределенные числа для коэффициентов U и V (по одному U и V на реализацию)
            NormDistr u = new NormDistr(Convert.ToDouble(MUTB.Text), Convert.ToDouble(DUTB.Text), Convert.ToInt32(NTB.Text));
            u.GenerateSelection();
            NormDistr v = new NormDistr(Convert.ToDouble(MVTB.Text), Convert.ToDouble(DVTB.Text), Convert.ToInt32(NTB.Text));
            v.GenerateSelection();
            U = u.GetSelection();
            V = v.GetSelection();

            int N = Convert.ToInt32(NTB.Text);
            int p = Convert.ToInt32(PointsCountTB.Text);
            double min = Convert.ToDouble(minTB.Text);
            double max = Convert.ToDouble(maxTB.Text);
            double h = (max - min) / p;
            double t = min;
            double y = 0;

            Chart1.Series.Clear();

            for (int j = 0; j < N; j++)
            {
                Chart1.Series.Add("realization" + (j + 1).ToString());
                Chart1.Series[j].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //считаем каждую точку графика
                for (int i = 0; i < p; i++)
                {
                    t = min + i * h;
                    y = U[j] * Math.Cos(2 * t) + V[j] * Math.Sin(t) + t;
                    Chart1.Series[j].Points.AddXY(t, y);
                }
            }
        }
    }
}

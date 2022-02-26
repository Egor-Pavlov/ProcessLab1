using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProcessLab1
{
    class NormDistr
    {
        private double M;//требуемое Мат.Ож
        private double S;//требуемое Откл.
        private int N;//требуемое кол-во.

        private List<double> Selection = new List<double>();
        public NormDistr(double M, double D, int N)
        {
            this.M = M;
            this.S = Math.Sqrt(D);
            this.N = N;
        }

        public List<double> GetSelection()
        {
            return Selection;
        }

        public void ExportSelection()
        {
            //создание папки для сохранения
            string completedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Test's");
            Directory.CreateDirectory(completedPath);

            string filePath = Path.Combine(completedPath, "NormSelection.xls");
            if(File.Exists(filePath))
            {
                int i = 1;
                while (File.Exists(Path.Combine(completedPath + "NormSelection" + i.ToString() + ".xls")))
                    i++;
                filePath = Path.Combine(completedPath + "NormSelection" + i.ToString() + ".xls");
            }

            //запись в файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (double s in Selection)
                {
                    writer.WriteLine(s);
                }
            }
        }

        public void GenerateSelection()
        {
            //Создание объекта для генерации чисел
            Random Rnd = new Random();
            double m, m1;//а и b - границы промежутка генерирования числа, m и s - мат.ож и откл. для равномерного распр.
                         //n - количество генераций равномерного распределения для суммирования
            int n;
            double a, b;
            a = 0;
            b = 1;
            m1 = a + b / 2;

            n = Convert.ToInt32(Math.Pow(S / (Math.Abs(b - a) / Math.Sqrt(12)), 2));

            m = n * m1;//m - фактическое мат. ож. полученного норм. распр.

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < N; j++)
                        Selection.Add(Rnd.NextDouble());
                }
                else
                {
                    for (int k = 0; k < N; k++)
                        Selection[k] += Rnd.NextDouble();
                }
            }

            for (int i = 0; i < N; i++)
                Selection[i] -= m - M;//корректировка для соотвествия матожидания заданному

        }
    }
}

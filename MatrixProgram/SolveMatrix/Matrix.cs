using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace SolveMatrix
{
    public class Matrix
    {
        public string Path { get; set; }
        public double[,] FirstMatrix { get; set; }
        public double[,] SecondMatrix { get; set; }
        public int ResultMatrixRows { get; set; }
        public int ResultMatrixCols { get; set; }
        public int K { get; set; }
        public double[,] ResultMatrix { get; set; }

        public Matrix()
        {
            this.Path = ConfigurationManager.AppSettings["path"];
        }
        //public void ReadFromFileSecond()
        //{
        //    while ((line = file.ReadLine()) != "")
        //    {
        //        continue;
        //    }
        //    while ((line = file.ReadLine()) != null)
        //    {
        //        lines.Add(line.Trim());
        //        Console.WriteLine(line);
        //    }
        //    file.Close();
        //    string[] numbers = lines[0].Split(' ');
        //    int rows = lines.Count, columns = numbers.Length;
        //    this.K = rows;
        //    this.ResultMatrixCols = columns;

        //    this.SecondMatrix = new double[rows, columns];
        //    int j = 0;
        //    int i = 0;
        //    foreach (var row in lines)
        //    {
        //        j = 0;
        //        foreach (var col in row.Trim().Split(' '))
        //        {
        //            this.SecondMatrix[i, j] = double.Parse(col.Trim());
        //            j++;
        //        }
        //        i++;
        //    }


        //}
        public void ReadFromFileFirst()
        {
            List<string> lines = new List<string>();
            string line, line2;
            System.IO.StreamReader file = new System.IO.StreamReader(this.Path);
            while ((line = file.ReadLine()) != "" )
            {
                lines.Add(line.Trim());
                Console.WriteLine(line);  
            }
            Console.WriteLine("111111111111111111111");
            while ((line2 = file.ReadLine()) != "")
            {
                lines.Add(line.Trim());
                Console.WriteLine(line2);
            }//почему цикл?
            file.Close();
            string[] numbers = lines[0].Split(' ');
            int rows = lines.Count, columns = numbers.Length;
            this.ResultMatrixRows = rows;
            this.FirstMatrix = new double[rows, columns];
            int j = 0;
            int i = 0;
            foreach (var row in lines)
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    this.FirstMatrix[i, j] = double.Parse(col.Trim());
                    j++;
                }
                i++;
            }
            

        }

        public void MultiplayMatrix()
        {
            this.ResultMatrix = new double[this.ResultMatrixRows, this.ResultMatrixCols];
            for (int i = 0; i < this.ResultMatrixRows; i++)

            {

                for (int j = 0; j < this.ResultMatrixCols; j++)

                {

                    this.ResultMatrix[i, j] = 0;

                    for (int k = 0; k < this.K; k++)

                    {

                        this.ResultMatrix[i, j] += this.FirstMatrix[i, k] * this.SecondMatrix[k, j];

                    }

                }

            }

            for (int i = 0; i < this.ResultMatrixRows; i++)

            {

                for (int j = 0; j < this.ResultMatrixCols; j++)

                {

                    Console.Write($"{ this.ResultMatrix[i, j]:F}\t");

                }

                Console.WriteLine();

            }

        }


    }
}

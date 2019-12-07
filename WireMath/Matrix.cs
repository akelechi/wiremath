using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireMath
{
    class MultiplyMatrix
    {
       
        private double[,] Matrix_A = new double[3, 3];
        private double[,] Matrix_F = new double[3, 3];
        private double[,] Matrix_G = new double[3, 3];
        private double[,] Matrix_B = new double[3, 3722];
        private double[,] Matrix_C = new double[3, 3722];
        private double[] Vector = new double[3];
        private double[] Vector_R = new double[3];
        
        public MultiplyMatrix ()
        {

        }

        public MultiplyMatrix(double[,]matrix_a, double[,]matrix_b, double[,] matrix_c, double[]vec)
        {
            Matrix_A = matrix_a;
            Matrix_B = matrix_b;
            Matrix_C = matrix_c; 
            Vector = vec;
        }

        public MultiplyMatrix(double[,] matrix_a, double[,] matrix_b)
        {
            Matrix_A = matrix_a;
            Matrix_B = matrix_b;
            
        }

        public MultiplyMatrix(double[,] matrix_a, double[] vec)
        {
            Matrix_A = matrix_a;
            Vector = vec;
            
        }

        private double[,] MatrixA
            {
            get { return Matrix_A; }
            set { Matrix_A = value; }
            }

        private double[,]MatrixB
        {
            get { return Matrix_B; }
            set { Matrix_B = value; }
        }

        private double[,] MatrixC
        {
            get { return Matrix_C; }
            set { Matrix_C = value; }
        }
        private double[] Vec
        {
            get { return Vector; }
            set { Vector = value; }
        }

        private double[] VecR
        {
            get { return Vector_R; }
            set { Vector_R = value; }
        }


        public double[] Multiply_oneD()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Vector_R[i] += Matrix_A[i, j] * Vector[j];
                }
            }
            return Vector_R;
        }

        public void Multiply_twoD(double [,]matrixOne, double[,]matrixTwo, double[,]result)
        {
            for (int i = 0; i < matrixOne.GetLength(0); i++)
            {
                for (int j = 0; j <matrixTwo.GetLength(1); j++)
                {
                    for(int k = 0; k< matrixTwo.GetLength(0); k++)
                   result[i,j] +=matrixOne[i, k] * matrixTwo[k,j];
                }
            }
            

        }
    }

}

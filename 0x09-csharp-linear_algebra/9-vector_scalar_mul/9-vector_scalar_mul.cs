using System;

///<summary>Class VectorMath</summary>
    class VectorMath
    {
        ///<summary>adds two vectors and returns the resulting vector</summary>
        ///<return>new vector with result</return>
        public static double[] Multiply(double[] vector, double scalar)
        {
            if (vector.Length == 2)
            {
                double[] two = new double[] {0, 0};
                two[0] = vector[0] * scalar;
                two[1] = vector[1] * scalar;
                return (two);
            }
            if (vector.Length == 3)
            {
                double[] three = new double[] {0, 0, 0};
                three[0] = vector[0] * scalar;
                three[1] = vector[1] * scalar;
                three[2] = vector[2] * scalar;
                return (three);       
            }
            else
            {
                double[] none = new double[] {-1};
                return(none);
            }
        }
    }
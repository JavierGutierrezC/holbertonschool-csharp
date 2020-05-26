using System;

///<summary>Class VectorMath</summary>
    class VectorMath
    {
        
        ///<summary>adds two vectors and returns the resulting vector</summary>
        ///<return>new vector with result</return>
        public static double[] Add(double[] vector1, double[] vector2)
        {
            if (vector1.Length == 2 && vector2.Length == 2 )
            {
                double[] two = new double[] {0, 0};
                two[0] = vector1[0] + vector2[0];
                two[1] = vector1[1] + vector2[1];
                return (two);
            }
            if (vector1.Length == 3 && vector2.Length == 3)
            {
                double[] three = new double[] {0, 0, 0};
                three[0] = vector1[0] + vector2[0];
                three[1] = vector1[1] + vector2[1];
                three[2] = vector1[2] + vector2[2];
                return (three);       
            }
            else
            {
                double[] none = new double[] {-1};
                return(none);
            }
        }
    }
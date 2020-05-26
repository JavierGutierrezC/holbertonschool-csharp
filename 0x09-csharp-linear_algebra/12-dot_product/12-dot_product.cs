using System;

///<summary>Class VectorMath</summary>
    class VectorMath
    {
        ///<summary>adds two vectors and returns the resulting vector</summary>
        ///<return>new vector with result</return>
        public static double DotProduct(double[] vector1, double[] vector2)
        {
            if (vector1.Length == 2 && vector2.Length == 2)
            {
                double two = vector1[0] * vector2[0];
                double two1 = vector1[1] * vector2[1];
                double ans = two + two1;
                return (ans);
            }
            if (vector1.Length == 3 && vector2.Length == 3)
            {
                double three = vector1[0] * vector2[0];
                double three1 = vector1[1] * vector2[1];
                double three2 = vector1[2] * vector2[2];
                double ans = three + three1 + three2;
                return (ans);       
            }
            else
            {
                return(-1);
            }
        }
    }
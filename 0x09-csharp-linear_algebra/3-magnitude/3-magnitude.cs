using System;

///<summary>Class VectorMath</summary>
    class VectorMath
    {
        
        ///<summary>returns the length of a given vector</summary>
        ///<return>length or -1</return>
        public static double Magnitude(double[] vector)
        {
            if (vector.Length == 2)
            {
                double two = (Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)));
                return (Math.Round(two, 2));
            }
            if (vector.Length == 3)
            {
                double three = (Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)));       
                return (Math.Round(three,2));
            }
            else
            {
                return (-1);
            }
        }
    }
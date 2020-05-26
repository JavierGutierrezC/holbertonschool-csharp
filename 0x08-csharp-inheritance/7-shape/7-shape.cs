﻿using System;


    ///<summary>Shape class</summary>
    class Shape
    {
        ///<summary>Public Method</summary>
        public virtual int Area()
        {
            throw new NotImplementedException("Area() is not implemented");       
        }
    }


    ///<summary>Rectangle Subclass of Shape</summary>       
    class Rectangle : Shape
    {
        private int width;
        private int height;

        public int Width
        {
            get
            {
            return(width);
            }
            set
            {
                if(value < 0)
                {
                   throw new ArgumentException("Width must be greater than or equal to 0"); 
                }
                else
                {
                    width = value;
                }
            }
        }

        public int Height
        {
            get
            {
                return(height);
            }
            set
            {
                if(value < 0)
                {
                   throw new ArgumentException("Height must be greater than or equal to 0"); 
                }
                else
                {
                    height = value;
                }
            }
        }


        public new int Area()
        {
            return(width*height);
        }
        public override string ToString()
        {
            return string.Format("[Rectangle] {0} / {1}", width, height);
        }
    }
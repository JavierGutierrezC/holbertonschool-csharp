﻿using System;

namespace Enemies
{
    ///<summary>Zombie class</summary>
    public class Zombie
    {
        ///<summary>health public field</summary>
        private int health;
        ///<summary>Zombie public constructor</summary>
        public Zombie()
        {
             health = 0;
        }
        ///<summary>Zombie public constructor that accepts a value</summary>
        public Zombie(int value)
        {
            
            if(value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
        }
        ///<summary>GetHealth public constructor</summary>
        public int GetHealth()
        {
            return(health);
        }

    }
}

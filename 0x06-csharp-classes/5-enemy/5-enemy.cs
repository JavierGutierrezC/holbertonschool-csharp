using System;

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
        ///<summary>Private field</summary>
        private string name = "No name";
        ///<summary>Public property Name</summary>
        public string Name
        {
            get 
            {
                return name;
            }
            set 
            {
                name = value;
            }
        }
        ///<summary>GetHealth public constructor</summary>
        public int GetHealth()
        {
            return(health);
        }
        ///<summary>ToString public override</summary>
        public override string ToString()
        {
            return string.Format("Zombie Name: {0} / Total Health: {1}", name, health);
        }   
    }
}

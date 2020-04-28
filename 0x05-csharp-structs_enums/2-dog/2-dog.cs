using System;


    public enum Rating {Good, Great, Excellent,}
    public struct Dog
    {
    public string name;
    public float age;
    public string owner;
    public Rating rating;
    

        public Dog(string lname, float lage, string lowner, Rating lrating)
        {
            name = lname;
            age = lage;
            owner = lowner;
            rating = lrating;
        }
    }
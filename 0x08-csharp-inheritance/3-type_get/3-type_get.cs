using System;
using System.Reflection;


    ///<summary>Obj class</summary>
    class Obj
    {
        ///<summary>method that prints the names 
        ///of the available properties and methods of an object.</summary>
        public static void Print(object myObj)
        {
            TypeInfo t = myObj.GetType().GetTypeInfo();
            Console.WriteLine("{0} Properties:", t.Name);
            foreach(PropertyInfo x in t.GetProperties())
            {
                Console.WriteLine(x.Name);
            }
            Console.WriteLine("{0} Methods:", t.Name);
            foreach(MethodInfo y in t.GetMethods())
            {
                Console.WriteLine(y.Name);
            }
        }
    }

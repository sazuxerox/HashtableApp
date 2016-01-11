using System;
using System.Collections;

namespace HashTableTestApp
{
    class Program
    {
        private static Hashtable GetHashtable()
        {
            //create and return new hashtable 
            var hashtable = new Hashtable { { "Area", 1000 }, { "Perimeter", 55 }, { "Mortgage", 540 } };
            return hashtable;
        }

        static void Main(string[] args)
        {
            var hashtable = GetHashtable();
            //see if the hashtable contains the key
            Console.WriteLine(hashtable.ContainsKey("Perimeter"));
            //test the contains method, it works the same way 
            Console.WriteLine(hashtable.Contains("Area"));
            //get value of area with indexer
            var value = (int)hashtable["Mortgage"];
            //write the value of the Area
            Console.WriteLine(value);
            Console.WriteLine("Printing all the values in the hashtable");
            //get all the keys of the hashtable
            ICollection key = hashtable.Keys;
            //loop through to the hashtable and print each of them
            foreach (var k in key)
            {
                Console.WriteLine(k + ": " + hashtable[k]);
            }

            //check if the a value is exist in the hashtable, if not add it the hashtable
            if (hashtable.ContainsValue(56000M))
            {
                Console.WriteLine("The value is already exist");
            }
            else
            {
                hashtable.Add("volume", 56000M);
            }
            Console.WriteLine("After adding new value to the hash");
            //loop through to the hashtable and print each of them after adding the new value to the hash
            foreach (var k in key)
            {
                Console.WriteLine(k + ": " + hashtable[k]);
            }
        }
    }
}

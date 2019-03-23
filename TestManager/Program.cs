using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Newtonsoft.Json;
using System.IO;
using TestFramework;
using System.Collections;
//Dawson Murphy
//CS 311
//This is a test engine designed to test a test framework. The framework is directly referenced, while the 
//sample tests are retrieved by parsing a json file. In the json file, there is a field call librariesToTest.
//The librariesToTest field is a list of one or more DLLs paths that the test engine look for at start-up to determine 
//what DLL(s) contain tests that the test engine should execute.  For each path, TestManager uses reflection to 
//query for attributes (defined in TestsFramework.dll) and drive the tests defined in the DLL(s). The current 
//json file provides only one DLL.
namespace TestManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parse json file and returns address of dll
            string json = File.ReadAllText("config.json");
            Locations locs = JsonConvert.DeserializeObject<Locations>(json);
            //Iterates through each library from json file
            foreach (string it in locs.librariesToTest)
            {
                Console.WriteLine("Beggining the test");
                Console.WriteLine();
                //Loads the dll as myLibrary
                Assembly myLibrary = Assembly.LoadFile(it);
                //Runs the tests
                RunTheTests(myLibrary);
                Console.WriteLine("The test is over");
            }
            //Makes sure the window stays open 
            Console.ReadLine();
        }

        //Method that takes in the Assembly for the tests, and runs the tests.
        private static void RunTheTests(Assembly a)
        {
            //Loads all the types in an array
            Type[] types = a.GetTypes();
            //Iterates through each type
            foreach (Type t in types)
            {
                SortedList methodsList = new SortedList(); //SortedList for running methods in order
                Attribute Classes = t.GetCustomAttribute(typeof(TestsAttribute));
                if (Classes != null) //If 
                {
                    Console.WriteLine("***Initializing " + t + "***");
                    foreach (MethodInfo mi in t.GetMethods())
                    {
                        //If the method is an instantiater
                        Attribute Instantiates = mi.GetCustomAttribute(typeof(TestsInitializeAttribute));
                        //If the method is a regular test method
                        Attribute Orders = mi.GetCustomAttribute(typeof(TestMethodAttribute));
                        int ord = 0; //Holds the priority for regular tests
                        try
                        {
                            ord = mi.GetCustomAttribute<TestMethodAttribute>().Order;

                        }
                        catch (NullReferenceException) { }
                        //If the method is a terminator
                        Attribute Terminates = mi.GetCustomAttribute(typeof(TestsTerminateAttribute));
                        //If it is an instantiation method, gives it highest priority in sortedlist
                        if (Instantiates != null) 
                        {
                            object o = Activator.CreateInstance(t);
                            methodsList.Add(0, mi);
                        }
                        //If it is a normal test method, uses its priority in the sortedlist
                        else if (Orders != null)
                        {
                            object o = Activator.CreateInstance(t);
                            methodsList.Add(ord, mi);
                        }
                        //If it is a terminate method, gives it lowest priority in the sortedlist
                        else if (Terminates != null)
                        {
                            object o = Activator.CreateInstance(t);
                            methodsList.Add(500, mi);
                        }
                    }
                    //Takes the sortedlist and runs the methods in order of their priority
                    for (int i = 0; i < methodsList.Count; i++)
                    {
                        //Loads the MethodInfo for the method from the sortedlist
                        MethodInfo temp = (MethodInfo)methodsList.GetByIndex(i);
                        //Creates the instance for the method
                        object o = Activator.CreateInstance(t);
                        //Runs the method (for the current sample tests, makes them print statements
                        //to the console)
                        object invoiceId = temp.Invoke(o, null);
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}





        
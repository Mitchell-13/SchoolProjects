using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOServerSide
{
    class ServerData
    {
        //New Random onject to grab a random joke or conspiracy
        Random rand = new Random();
        //arrays to hold the text file contents
        string[] majors;
        string[] facts;
        //file names of the text files so we can access them
        const string MAJOR_FILE = "UVUCourseDescriptions.txt";
        const string FACTS_FILE = "UVUFacts.txt";

        public void LoadFiles()
        {
            try
            {
                //read all the lines from the jokes.txt file then assign the results to the jokes string array
                majors = File.ReadAllLines(MAJOR_FILE);
                //read all the lines from the conspiracies.txt file then assign the result to the conspiracies string array
                facts = File.ReadAllLines(FACTS_FILE);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string GetRandomMajor()
        {
            //using the jokes array and the random class, grab a random index from the jokes array with the jokes array's length being the upper limit
            return majors[rand.Next(majors.Length)];
        }
        public string GetRandomFact()
        {
            return facts[rand.Next(facts.Length)];
        }
    }
}

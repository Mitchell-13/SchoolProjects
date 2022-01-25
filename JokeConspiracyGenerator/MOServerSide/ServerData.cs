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
        string[] jokes;
        string[] conspiracies;
        //file names of the text files so we can access them
        const string JOKE_FILE = "jokes.txt";
        const string CONSPIRACY_FILE = "conspiracies.txt";

        public void LoadFiles()
        {
            try
            {
                //read all the lines from the jokes.txt file then assign the results to the jokes string array
                jokes = File.ReadAllLines(JOKE_FILE);
                //read all the lines from the conspiracies.txt file then assign the result to the conspiracies string array
                conspiracies = File.ReadAllLines(CONSPIRACY_FILE);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string GetRandomJoke()
        {
            //using the jokes array and the random class, grab a random index from the jokes array with the jokes array's length being the upper limit
            return jokes[rand.Next(jokes.Length)];
        }
        public string GetRandomConspiracy()
        {
            return conspiracies[rand.Next(conspiracies.Length)];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace MOServerSide
{
    public class SynchronousSocketListener
    {
        //serverdata variable, will take care of loading text file data and getting random jokes/conspiracies
        ServerData server;
        //will take care of listening for TCP requests
        TcpListener tcpListener;
        //constant variables for the port number, ip address, and joke/conspiracy validation
        const int PORT = 11000;
        const string IP_ADDRESS = "127.0.0.1";
        const string JOKE = "JOKE";
        const string CONSPIRACY = "CONSPIRACY";

        public SynchronousSocketListener()
        {
            //instatiates a new serverdata object and assigns it to the server variable
            server = new ServerData();
            //load the text file data
            server.LoadFiles();
        }
        public void StartListening()
        {
            //parse our IP address constant into an actual IP addres used by system.net
            IPAddress iPAddress = IPAddress.Parse(IP_ADDRESS);
            //new tcplistener object will listen for requests made using the provided ip address and port
            tcpListener = new TcpListener(iPAddress, PORT);
            //starts listening
            tcpListener.Start();

            ProcessSocket();
        }
        public void ProcessSocket()
        {
            //create a socket for later use eventually, this will open the data stream to let us read and write to it
            Socket socket;
            while (true)
            {
                try
                {
                    //acceptsocket() returns a socket using the tcp stream that can be used to read/write datat to the stream
                    socket = tcpListener.AcceptSocket();
                    //using our socket, open the data stream then create a new streamreader and streamwriter to read and write to the data stream
                    NetworkStream ns = new NetworkStream(socket);
                    StreamReader reader = new StreamReader(ns);
                    StreamWriter writer = new StreamWriter(ns);
                    //every time we write to the server, we will immediately flush the buffer to the stream instead of waiting for the buffer to fill up. This will also ensure the data is accurate.
                    writer.AutoFlush = true;
                    //Grabs the client request
                    string clientRequest = reader.ReadLine();
                    //write the client request to the console
                    Console.WriteLine($"Recieved from client: {clientRequest}");
                    //check if client requested joke
                    if (clientRequest.ToUpper() == JOKE)
                    {
                        //assign a random joke from our server to a new string variable named joke
                        string joke = $"Joke: { server.GetRandomJoke()}";
                        //send random joke to client
                        writer.WriteLine(joke);
                        //display the random joke to the console
                        Console.WriteLine(joke);
                    }
                    else if (clientRequest.ToUpper() == CONSPIRACY)
                    {
                        string conspiracy = $"Conspiracy: {server.GetRandomConspiracy()}";
                        Console.WriteLine(conspiracy);
                        writer.WriteLine(conspiracy);
                    }
                    else
                    {
                        writer.WriteLine($"Could not do anything with: {clientRequest}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    
}

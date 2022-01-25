using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace MOClientSide
{
    class SynchronousSocketClient
    {
        const int SERVER_PORT = 11000;

        const string IP_ADDRESS = "127.0.0.1";


        public string ContactServer(string request)
        {
            string responseString = "";
            try
            {
                //instantiate new tcpclient that will be used to establish a connection to our server
                TcpClient tcpClient = new TcpClient();
                //connect to tcp host or our server, in this case
                tcpClient.Connect(IPAddress.Parse(IP_ADDRESS), SERVER_PORT);
                //access the data stream between the client and the server and gives it the name networkstream
                NetworkStream clientServerDataStream = tcpClient.GetStream();
                //Create a new streamwriter that will write to our server
                StreamWriter streamWriter = new StreamWriter(clientServerDataStream);
                //create a new streamreader that will read from our server
                StreamReader streamReader = new StreamReader(clientServerDataStream);
                //every time we write to the server, we will immediatley flush the buffer to the stream instead of waiting for the buffer to fill up
                streamWriter.AutoFlush = true;
                //write our request to the server
                streamWriter.WriteLine(request);
                //read the response from the server
                responseString = streamReader.ReadLine();
                //close the data stream and the connection
                clientServerDataStream.Close();
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                responseString = ex.Message;
            }
            return responseString;
        }
    }
}

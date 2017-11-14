using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jarvis_WindowsClient.network {

    public class JarvisNetwork {

        private Action<JarvisNetworkEvent> eventCallback;

        public void startListening(){

            UdpClient serverSocket = new UdpClient();
            serverSocket.Client.Bind(new IPEndPoint(IPAddress.Any, 53146));

            IPEndPoint from = new IPEndPoint(0, 0);
            
            while (true){
                byte[] recvBuffer = serverSocket.Receive(ref from);
            
                eventCallback(new JarvisNetworkEvent(recvBuffer));
                //Console.WriteLine(Encoding.UTF8.GetString(recvBuffer));
            }
        }

        public JarvisNetwork(Action<JarvisNetworkEvent> callback) {

            eventCallback = callback;

            Thread networkThread = new Thread(startListening);
            networkThread.Start();
           
        }

        
     




    }


}

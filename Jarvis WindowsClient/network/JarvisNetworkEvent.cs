using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis_WindowsClient.network {

    public class JarvisNetworkEvent {

        public string deviceName;
        public string deviceAddr;
        public string command;
        public string data;

        public JarvisNetworkEvent(byte[] recievedPackage) {
            deviceName = "";
        }


    }
}

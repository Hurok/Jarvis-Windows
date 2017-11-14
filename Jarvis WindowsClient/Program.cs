using Jarvis_WindowsClient.network;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jarvis_WindowsClient{

    class Program {

        private static Program main;
        private NotifyIcon trayIcon;
        private JarvisNetwork network;

        private void jarvisEvent(string jarvisEvent) {
            Console.WriteLine(jarvisEvent);
            main.trayIcon.BalloonTipText = jarvisEvent;
            main.trayIcon.BalloonTipTitle = jarvisEvent;
            main.trayIcon.ShowBalloonTip(5000);
           // main.trayIcon.
        }
       

        [STAThread]
        static void Main(){

            main = new Program();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            main.trayIcon = new NotifyIcon();
            main.network = new JarvisNetwork(main.jarvisEvent);


            main.trayIcon.Icon = SystemIcons.Application;
            main.trayIcon.Visible = true;
            //trayIcon.Icon
            Application.Run();
        }



    }
}

using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

using System.Threading.Tasks;

namespace Tester
{
    internal class Server
    {
        #region datas
        private Socket sListener;
        private Thread serverThread;
        #endregion
        #region properties
        public bool IsRunning { get; private set; }
        #endregion
        #region constructors
        public Server()
        {
            this.IsRunning = false;
            this.serverThread = new Thread(this.RunServer);
        }
        #endregion
        #region methods
        public void Run()
        {
            this.IsRunning = true;
            this.RunServer();
        }
        public void RunAsynhronous()
        {
            this.IsRunning = true;
            this.serverThread.Start();
        }

        private void RunServer()
        {
            while (true)
            {

            }
            this.IsRunning = false;
            this.serverThread.Abort();
        }
        #endregion
    }
}

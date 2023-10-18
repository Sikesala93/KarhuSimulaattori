using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;

public class TCPServer : MonoBehaviour
{

    private Thread tcpListenerThread;
    private TcpListener tcpListener;
    private bool run = true;
    private TcpClient connectedClient;

    public static int inputValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        tcpListenerThread = new Thread(new ThreadStart(Listen));
        tcpListenerThread.IsBackground = true;
        tcpListenerThread.Start();
    }

    private void OnDisable()
    {
        run = false;
        tcpListenerThread.Interrupt();
        tcpListenerThread.Abort();
        tcpListener.Start();
    }

    public void Listen()
    {
        try
        {
            tcpListener = new TcpListener(IPAddress.Any, 9999);
            tcpListener.Start();
            Debug.Log("TCPServer - Listen() -> Server starting");

            Byte[] bytes = new Byte[1024];

            while (run)
            {
                using (connectedClient = tcpListener.AcceptTcpClient())
                {
                    Debug.Log("TCPServer - Listen() -> New connection");

                    using (NetworkStream stream = connectedClient.GetStream()) 
                    {

                        int length = 0;
                        while ((length = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            inputValue = BitConverter.ToInt32(bytes, 0);

                            Debug.Log("TCPServer - Listen() -> New value" + inputValue);

                        }

                    }
                }

            }
        }
        catch(SocketException socketException)
        {
            Debug.LogError("TCPServer - Listen()" + socketException);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

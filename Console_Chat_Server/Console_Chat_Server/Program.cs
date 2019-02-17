//TCP 채팅 서버, 클라이언트 끊어졌을 때 체크하여 로깅 

using System;

using System.Collections.Generic;

using System.IO;

using System.Net;

using System.Net.Sockets;

using System.Text;

using System.Threading;

class Server

{

    // 클라이언트가 다수 접속하므로 서버가 AcceptSocket 으로 생성한

    // 클라이언트 상대하는 소켓을 ArrayList등에 보관하고 글을 쓸 때

    // 현재 접속한 클라이언트 모두에게 글을 보내야 한다.

    static List<Socket> clientSockets = new List<Socket>();

    public static void Main()

    {

        //IP주소를 나타내는 객체,TcpListener를 생성시 인자로 사용

        IPAddress ip = IPAddress.Parse("127.0.0.1");

        try

        {

            //TcpListener Class를 이용하여 클라이언트의 연결을 받아 들인다.

            TcpListener listener = new TcpListener(ip, 5001);

            listener.Start();

            //Client Line Check..

            // new Thread(() => checkline()).Start();



            //서버프로그램은 데몬프로그램처럼 늘 기동되어 있어야 하므로 무한루프로

            while (true)

            {

                Socket socket = listener.AcceptSocket();

                new Thread(() => chat(socket)).Start();

            }

        }

        catch (Exception e)

        {

            Console.WriteLine(e);

        }

    }



    static void checkline()

    {

        Encoding encoding = Encoding.GetEncoding("euc-kr");

        String line;

        while (true)
        {

            if (clientSockets.Count > 0)

            {

                foreach (Socket s in clientSockets)

                {

                    StreamReader reader = new StreamReader(new NetworkStream(s), encoding);

                    if ((line = readLine(reader, s)) == null)

                    {

                        Console.WriteLine($"IP : {s.RemoteEndPoint} Closed Please Reconnect...");

                        break;

                    }

                }

            }

        }

    }





    //Thread가 실행할 메소드, 인자로 클라이언트 전담 소켓을 받는다.

    static void chat(Socket socket)

    {

        Encoding encoding = Encoding.GetEncoding("euc-kr");

        try

        {

            clientSockets.Add(socket);

            StreamReader reader = new StreamReader(new NetworkStream(socket), encoding);

            string line;

            while ((line = readLine(reader, socket)) != null)

            {

                Console.WriteLine(line);

                // ArrayList에 보관된 모든 클라이언트 처리 소켓만큼

                // 현재 접속한 모든 클라이언트에게 글을 씀

                foreach (Socket clientSocket in clientSockets)

                {

                    //클라이언트의 데이터를 읽고, 쓰기 위한 스트림을 만든다.

                    NetworkStream stream = new NetworkStream(clientSocket);

                    StreamWriter writer = new StreamWriter(stream, encoding) { AutoFlush = true };

                    writer.WriteLine(line);

                    writer.Close();

                }

            }

        }

        catch

        {

        }

        finally

        {

            clientSockets.Remove(socket);

            socket.Close();

            socket = null;

        }

    }

    static string readLine(StreamReader reader, Socket socket)

    {

        try

        {

            return reader.ReadLine();

        }

        catch

        {

            Console.WriteLine("Connection Error!");

            Console.WriteLine($"IP : {socket.RemoteEndPoint} Closed Please Reconnect...");

            return null;

        }

    }

}

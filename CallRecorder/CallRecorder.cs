using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CallRecorder
{
    public static class CallRecorder
    {
       static  String  TCP_IP_ADDRESS = "192.168.1.62";
        static int PORT = 20001;
        static String DATEBASE_PATH = "D:\\Voicedata";

        static TcpClient tcpclnt;
        static Stream stm;
      //  static Recording Record;
     
      
       


        public static  List<Recording> GetRecordingsForTelephoneNumbers(String T1, String T2 = "", String T3 = "")
        {

            String Filter = "";
            if (T1 != "")
            {
                Filter = "calledParty='" + T1 + "'";
            }

            if (T2 != "")
            {
                Filter = $"{Filter} or calledParty='{T2}'";
            }
            if (T3 != "")
            {
                Filter = $"{Filter} or calledParty='{T3}'";
            }


            String r = SendSQLQuery($"Select uid , calledParty ,setupTime ,disconnectTimeMs, connectTimeMs , fileSize from eyesdn where {Filter} order by setupTime desc;");
  //String r = SendSQLQuery($"Select * from eyesdn where {Filter} order by setupTime desc;");

            return CreateListOfRecordings(r);
        }


        private static List<Recording> CreateListOfRecordings(string r)
        {
            List<Recording> l = new List<Recording>();
            string[] lines = r.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);


            for (int i = 1; i < lines.Count() - 1; i++)
            {
                l.Add(new Recording(lines[0], lines[i]));
            }
            return l;

        }

        public static void GetRecording(String uid, long FileSize)
        {
            DoHandShake();

            SendCommand("get " + uid + ";");
            Console.WriteLine(ReadReply());

            SaveFile(FileSize);

            CloseConnection();

        }



        private static String SendSQLQuery(String sql)
        {
          DoHandShake();
            //run sql
            SendCommand(sql);

            System.Threading.Thread.Sleep(1000);
            String Reply = ReadReply();

            //close
            Console.Write(Reply);

            CloseConnection();
            return Reply;
        }

        public static void SaveFile(long FileSize)
        {
            string rootDir;
            rootDir = @"C:\Client Data" + "\\";
            Directory.CreateDirectory(rootDir);
            FileStream fout = new FileStream(rootDir + "\\tmp.wav", FileMode.Create, FileAccess.Write);

            long rby = 0;
            try
            {
                while (rby < FileSize)
                {
                    byte[] buffer = new byte[1024];
                    int i = stm.Read(buffer, 0, buffer.Length);

                    fout.Write(buffer, 0, (int)i);
                    rby = rby + i;
                }
                fout.Close();
            }
            catch (Exception ed)
            {
                Console.WriteLine("A Exception occured in file transfer" + ed.ToString());

            }
        }


        private static void SendCommand(String Command)
        {
            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = asen.GetBytes(Command);
            Console.WriteLine("Transmitting..... " + Command);

            stm.Write(ba, 0, ba.Length);
        }


        private static String ReadReply()
        {
            byte[] bb = new byte[65000];
            int k = stm.Read(bb, 0, 65000);
            Console.WriteLine(k.ToString());
            String Reply = "";
            for (int i = 0; i < k; i++)
            {
                Reply = Reply + (Convert.ToChar(bb[i]));
            }
            return Reply;
        }

        private static void DoHandShake()
        {
            tcpclnt = new TcpClient();

            Console.WriteLine("Connecting.....");

            tcpclnt.Connect(TCP_IP_ADDRESS , PORT);
           

            stm = tcpclnt.GetStream();

            Console.WriteLine(ReadReply());
            // select database
            SendCommand($"use {DATEBASE_PATH};");

            Console.WriteLine(ReadReply());
        }

        private static void CloseConnection()
        {
            tcpclnt.Close();
            Console.WriteLine("closed.....");
        }

    }
}

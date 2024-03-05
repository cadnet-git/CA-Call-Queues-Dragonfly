using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallRecorder
{
   public class Recording
    {

        public Recording(String Header, String Record)
        {

            String[] heads = Header.Split(',');
            String[] vals = Record.Split(',');

            // remove the brackets from the data

            for (int i = 0; i < heads.Length; i++)
            {
                heads[i] = heads[i].Replace("[", "").Replace("]", "").Trim();
            }
            for (int i = 0; i < vals.Length; i++)
            {
                vals[i] = vals[i].Replace("[", "").Replace("]", "").Trim();
            }

            for (int i = 0; i < heads.Length; i++)
            {
              
                switch (heads[i])
                {

                    case "uid":
                        uid = vals[i];
                        break;
                    case "calledParty":
                        CalledParty = vals[i];
                        break;
                    case "setupTime":
                        SetupTime = DateTime.Parse(vals[i]);
                        break;
                    case "connectTimeMs":
                        RingTimeSeconds = TimeSpan.FromMilliseconds(int.Parse(vals[i]));
                        break;
                    case "disconnectTimeMs":
                        ConnectedTimeSeconds = TimeSpan.FromMilliseconds(int.Parse(vals[i]));
                        break;

                    case "fileSize":
                        FileSize = long.Parse(vals[i]);
                        break;

                    default:
                        break;
                }
            }
        }

        public String uid { get; set; }

        public String CalledParty { get; set; }

        public DateTime SetupTime { get; set; }

        public TimeSpan RingTimeSeconds { get; set; }

        public TimeSpan ConnectedTimeSeconds { get; set; }

        public long FileSize { get; set; }



    }
}





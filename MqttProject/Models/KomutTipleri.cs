using System.Collections.Generic;

namespace MqttProject.Models
{
    public class KomutTipleri
    {
      
        public string Lable { get; set; }
        public static string LOGIN { get; private set; }
        
        public static string GETDEVICEINFO { get; private set; }
        public static string GETTIME { get; private set; }
        public static string SETTIME { get; private set; }
        public static string GETCONFIG { get; private set; }
        public static string SETCONFIG { get; private set; }
        public static string RESTARTDEVICE { get; private set; }
        public static string RESTARTRFMODULE { get; private set; }
        public static string STARTMQTTTRACE { get; private set; }
        public static string STOPMQTTTRACE { get; private set; }
        public static string ADDTASK { get; private set; }
        public static string ADDTASKLIST { get; private set; }
        public static string REMOVETASK { get; private set; }
        public static string REMOVEALLTASKS { get; private set; }
        public static string GETTASKLIST { get; private set; }
        public static string GETINPUTLIST { get; private set; }
        public static string GETINPUTPULSECOUNTLIST { get; private set; }
        public static string SETINPUTPULSECOUNTLIST { get; private set; }
        public static string GETOUTPUTLIST { get; private set; }
        public static string SETOUTPUTLIST { get; private set; }
        public static string EXECTPCHANNELCMD { get; private set; }
        public static string EXECDIAGOPER { get; private set; }

        public static List<string> GetList() {



        List<string> list = new List<string>();
            list.Add("LOGIN");
            list.Add((string)GETDEVICEINFO);
            list.Add(GETTIME.Valu);
            list.Add(SETTIME);
            list.Add(GETCONFIG);
            list.Add(SETCONFIG);
            list.Add(RESTARTDEVICE);
            list.Add(RESTARTRFMODULE);
            list.Add(STARTMQTTTRACE);
            list.Add(STOPMQTTTRACE);
            list.Add(ADDTASK);
            list.Add(ADDTASKLIST);
            list.Add(REMOVETASK);
            list.Add(REMOVEALLTASKS);
            list.Add(GETTASKLIST);
            list.Add(GETINPUTLIST);
            list.Add(GETINPUTPULSECOUNTLIST);
            list.Add(SETINPUTPULSECOUNTLIST);
            list.Add(GETOUTPUTLIST);
            list.Add(SETOUTPUTLIST);
            list.Add(EXECTPCHANNELCMD);
            list.Add(EXECDIAGOPER);
            return list;



        }

    }
  
}

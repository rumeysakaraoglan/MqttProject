using System.Collections.Generic;

namespace MqttProject.Models
{
    public class KomutTipleri
    {

        //public string LABEL = "LABEL";
        public static string LOGIN = "LOGIN";

        public static string GETDEVICEINFO = "GETDEVICEINFO";
        public static string GETTIME = "GETTIME";
        public static string SETTIME = "SETTIME";
        public static string GETCONFIG = "GETCONFIG";
        public static string SETCONFIG = "SETCONFIG";
        public static string RESTARTDEVICE = "RESTARTDEVICE";
        public static string RESTARTRFMODULE = "RESTARTRFMODULE";
        public static string STARTMQTTTRACE = "STARTMQTTTRACE";
        public static string STOPMQTTTRACE = "STOPMQTTTRACE";
        public static string ADDTASK = "ADDTASK";
        public static string ADDTASKLIST = "ADDTASKLIST";
        public static string REMOVETASK = "REMOVETASK";
        public static string REMOVEALLTASKS = "REMOVEALLTASKS";
        public static string GETTASKLIST = "GETTASKLIST";
        public static string GETINPUTLIST = "GETINPUTLIST";
        public static string GETINPUTPULSECOUNTLIST = "GETINPUTPULSECOUNTLIST";
        public static string SETINPUTPULSECOUNTLIST = "SETINPUTPULSECOUNTLIST";
        public static string GETOUTPUTLIST = "GETOUTPUTLIST";
        public static string SETOUTPUTLIST = "SETOUTPUTLIST";
        public static string EXECTPCHANNELCMD = "EXECTPCHANNELCMD";
        public static string EXECDIAGOPER = "EXECDIAGOPER";

        //public static string LOGIN { get; private set; }

        public static List<string> GetList()
        {

            List<string> list = new List<string>();
            list.Add(LOGIN);
            list.Add(GETDEVICEINFO);
            list.Add(GETTIME);
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

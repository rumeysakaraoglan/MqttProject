using System.Data;

namespace MqttProject.Models
{
    public class Komut
    {
        public int Id { get; set; }
        public int CihazId { get; set; }

        public int ModemId { get; set; }
        public int KomutKod { get; set; }
        public string KomutParams { get; set; }
        public int BaglantiDenemeSayisi { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime DataTime { get; set; }//Komutun çalıştıgı tarih
        public int Durum { get; set; }


        public ModemGorev ModemGorev { get; set; }

       
    }
  
}
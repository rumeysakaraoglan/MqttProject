using System.Data;

namespace MqttProject.Models
{
    public class Komut
    {
        public int Id { get; set; }
        public int Cihazid { get; set; }

        public int Modemid { get; set; }
        //public virtual ModemGorev ModemGorev { get; set; }
        public int Komutkod { get; set; }
        public string? Komutparams { get; set; }
        public int Baglantidenemesayisi { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime Datatime { get; set; }//Komutun çalıştıgı tarih
        public int Durum { get; set; }


      

       
    }
  
}
namespace MqttProject.Models
{
    public class ModemGorev
    {
            public int? rc { get; set; } //rc ne 
            public int Id { get; set; }
            public int? Komutid { get; set; }
            public virtual Komut Komut { get; set; }
            public string Modemserino { get; set; }
            public int Gorevid { get; set; }
            public string Param { get; set; }
            public DateTime? Tarih { get; set; }
          
            public int Tip { get; set; }
            public long Periyot { get; set; }

            public int Dakika { get; set; }
            public int Saat { get; set; }
            public int Gun { get; set; }
            public DateTime? Baslangictarihi { get; set; }
            public DateTime? Bitistarihi { get; set; }
             public ModemGorev()
             {} 
    }
   
}


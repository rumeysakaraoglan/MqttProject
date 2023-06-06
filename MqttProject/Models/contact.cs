namespace MqttProject.Models
{
     
    public class contact
    {
        public int Id { get; set; }
        public string ServerAden { get; set; }

        public string SubscribeTopic { get; set; }

        public contact() { }

        public contact(int id, string serverAden, string subscribeTopic)
        {
            this.Id= id;
            this.ServerAden= serverAden;
            this.SubscribeTopic= subscribeTopic;
        }
        //public class Book
        //{
        //    public int id { get; set; }
        //    public string Title { get; set; }
        //    public string Author { get; set; }

        //}
        //}
     
    }
}

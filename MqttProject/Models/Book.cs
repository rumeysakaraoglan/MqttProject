namespace MqttProject.Models
{
    public class Book
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public Book()
        {

        }
        public Book(int id, string title, string author)
        {
            this.id = id;   
            this.Title = title;
            this.Author = author;
        }
    }
   
}

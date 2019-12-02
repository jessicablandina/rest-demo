using rest_demo.Source.Models;

namespace rest_demo
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int Year { get; set; }

        public Book(int Id, string Title, int AuthorId, int Year)
        {
            this.Id = Id;
            this.Year = Year;
            this.AuthorId = AuthorId;
            this.Title = Title;
        }

    }
}
    
using System;
namespace rest_demo.Source.Models
{
    public class Author
    {

        public string Name { get; set; }
        public int Id { get; set; }

        public Author(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
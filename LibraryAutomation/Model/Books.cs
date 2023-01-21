using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Model
{
    public class Books
    {
        public int book_id { get; set; }
        public string book_name { get; set; }
        public string book_author { get; set; }
        public string book_language { get; set; }
        public string book_publishing_house { get; set; }
        public string book_type { get; set; }
        public int book_piece { get; set; }
        public int book_pages { get; set; }
        public int book_year_of_release { get; set; }


        public Books() 
        { 

        }

        public Books(int book_id, string book_name, string book_author, string book_language,
            string book_publishing_house, string book_type, int book_piece, int book_pages,
            int book_year_of_release)
        {
            this.book_id = book_id;
            this.book_name = book_name;
            this.book_author = book_author;
            this.book_language = book_language;
            this.book_publishing_house = book_publishing_house;
            this.book_type = book_type;
            this.book_piece = book_piece;
            this.book_pages = book_pages;
            this.book_year_of_release = book_year_of_release;
        }


        public int getBookId()
        {
            return book_id;
        }


        public string getBookName()
        {
            return book_name;
        }


        public string getBookAuthor()
        {
            return book_author;
        }


        public string getBookLanguage()
        {
            return book_language;
        }


        public void setBookLanguage(string book_language)
        {
            this.book_language = book_language;
        }

        
        public string getBookPublishingHouse()
        {
            return book_publishing_house;
        }


        public string getBookType()
        {
            return book_type;
        }


        public int getBookPiece()
        {
            return book_piece;
        }


        public int getBookPages()
        {
            return book_pages;
        }


        public int getBookYearOfRelease()
        {
            return book_year_of_release;
        }

    }
}

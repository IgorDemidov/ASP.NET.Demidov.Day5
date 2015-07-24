using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStorage.Task1.Library
{
    public class Book : IEquatable<Book>, IComparable<Book>
    {
        #region Properties

        public string Author { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public int PageCount { get; set; }
        public int ImprintDate { get; set; }

        #endregion

        #region Constructors

        public Book(string author, string title, string category, int pageCount, int imprintDate)
        {
            Author = author;
            Title = title;
            Category = category;
            PageCount = pageCount;
            ImprintDate = imprintDate;
        }
        public Book()
            : this("None", "None", "None", 0, 0){}

        #endregion

        #region Object methods overriding

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        } 

        #endregion

        #region IEquatable<Book> implementation

        public bool Equals(Book other)
        {
            throw new NotImplementedException();
        }

	    #endregion

        #region IComparable<Book> implementation

        public int CompareTo(Book other)
        {
            throw new NotImplementedException();
        }

        #endregion




        
    }
}

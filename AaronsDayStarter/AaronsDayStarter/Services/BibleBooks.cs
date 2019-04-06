using System; 
using System.Collections.Generic;
using System.Text;

namespace AaronsDayStarter.Services
{
    public class BibleBook
    {
        public BibleBook()
        {

        }
        public BibleBook(String Testament, String Book, String Section, Int32 Chapters)
        {
            this.Testament = Testament;
            this.Book = Book;
            this.BibleSection = Section;
            this.Chapters = Chapters;
        }
        public String Testament { get; set; }
        public String Book { get; set; }
        public String BibleSection { get; set; }
        public Int32 Chapters { get; set; }
    }

    public static class BibleBooks
    {
        public static List<BibleBook> Books { get
            {
                List<BibleBook> bks = new List<BibleBook>();
                bks.Add(new BibleBook("OT", "Genesis","Moses", 50 ));
                bks.Add(new BibleBook("OT", "Exodus","Law", 40 ));
                bks.Add(new BibleBook("OT", "Leviticus","Law", 27 ));
                bks.Add(new BibleBook("OT", "Numbers","Law", 36 ));
                bks.Add(new BibleBook("OT", "Deuteronomy","Law", 34 ));

                bks.Add(new BibleBook("OT", "Joshua","History", 24 ));
                bks.Add(new BibleBook("OT", "Judges","History", 21 ));
                bks.Add(new BibleBook("OT", "Ruth","History", 4 ));
                bks.Add(new BibleBook("OT", "1 Samuel","History", 31 ));
                bks.Add(new BibleBook("OT", "2 Samuel","History", 24 ));
                bks.Add(new BibleBook("OT", "1 Kings","History", 22 ));
                bks.Add(new BibleBook("OT", "2 Kings","History", 25 ));
                bks.Add(new BibleBook("OT", "1 Chronicles","History", 29 ));
                bks.Add(new BibleBook("OT", "2 Chronicles","History", 36));
                bks.Add(new BibleBook("OT", "Ezra","Stories", 10 ));
                bks.Add(new BibleBook("OT", "Nehemiah","Stories", 13 ));
                bks.Add(new BibleBook("OT", "Esther","Stories", 10 ));
                bks.Add(new BibleBook("OT", "Job", "Wisdom", 42 ));
                bks.Add(new BibleBook("OT", "Psalms","Poetry", 150 ));
                bks.Add(new BibleBook("OT", "Proverbs","Wisdom", 31 ));
                bks.Add(new BibleBook("OT", "Ecclesiastes","Wisdom", 12 ));
                bks.Add(new BibleBook("OT", "Song of Solomon","Wisdom", 8 ));
                bks.Add(new BibleBook("OT", "Isaiah","Propecy", 66 ));
                bks.Add(new BibleBook("OT", "Jeremiah","Propecy", 52 ));
                bks.Add(new BibleBook("OT", "Lamentations", "Wisdom", 5 ));
                bks.Add(new BibleBook("OT", "Ezekiel", "Stories", 48 ));
                bks.Add(new BibleBook("OT", "Daniel", "Stories", 12 ));
                bks.Add(new BibleBook("OT", "Hosea","Propecy", 14 ));
                bks.Add(new BibleBook("OT", "Joel","Propecy", 3 ));
                bks.Add(new BibleBook("OT", "Amos","Propecy", 9 ));
                bks.Add(new BibleBook("OT", "Obadiah","Propecy", 1 ));
                bks.Add(new BibleBook("OT", "Jonah","Propecy", 4 ));
                bks.Add(new BibleBook("OT", "Micah","Propecy", 7 ));
                bks.Add(new BibleBook("OT", "Nahum","Propecy", 3 ));
                bks.Add(new BibleBook("OT", "Habakkuk","Propecy", 3 ));
                bks.Add(new BibleBook("OT", "Zephaniah","Propecy", 3 ));
                bks.Add(new BibleBook("OT", "Haggai","Propecy", 2 ));
                bks.Add(new BibleBook("OT", "Zechariah","Propecy", 14 ));
                bks.Add(new BibleBook("OT", "Malachi","Propecy", 4 ));

                bks.Add(new BibleBook("NT", "Matthew","Gospel", 28 ));
                bks.Add(new BibleBook("NT", "Mark","Gospel", 16 ));
                bks.Add(new BibleBook("NT", "Luke","Gospel", 24 ));
                bks.Add(new BibleBook("NT", "John","Gospel", 21 ));
                bks.Add(new BibleBook("NT", "Acts","History", 28 ));
                bks.Add(new BibleBook("NT", "Romans","Paul", 16 ));
                bks.Add(new BibleBook("NT", "1 Corinthians","Paul", 16 ));
                bks.Add(new BibleBook("NT", "2 Corinthians","Paul", 13 ));
                bks.Add(new BibleBook("NT", "Galatians","Paul", 6 ));
                bks.Add(new BibleBook("NT", "Ephesians","Paul", 6 ));
                bks.Add(new BibleBook("NT", "Philippians","Paul", 4 ));
                bks.Add(new BibleBook("NT", "Colossians","Paul", 4 ));
                bks.Add(new BibleBook("NT", "1 Thessalonians","Paul", 5 ));
                bks.Add(new BibleBook("NT", "2 Thessalonians","Paul", 3 ));
                bks.Add(new BibleBook("NT", "1 Timothy","Paul", 6 ));
                bks.Add(new BibleBook("NT", "2 Timothy","Paul", 4 ));
                bks.Add(new BibleBook("NT", "Titus","Paul", 3 ));
                bks.Add(new BibleBook("NT", "Philemon","Paul", 1 ));
                bks.Add(new BibleBook("NT", "Hebrews","Unknown", 13 ));
                bks.Add(new BibleBook("NT", "James","James", 5 ));
                bks.Add(new BibleBook("NT", "1 Peter","Peter", 5 ));
                bks.Add(new BibleBook("NT", "2 Peter", "Peter", 3 ));
                bks.Add(new BibleBook("NT", "1 John","John", 5 ));
                bks.Add(new BibleBook("NT", "2 John","John", 1 ));
                bks.Add(new BibleBook("NT", "3 John","John", 1 ));
                bks.Add(new BibleBook("NT", "Jude","Paul", 1 ));
                bks.Add(new BibleBook("NT", "Revelation","John", 22 ));
                return bks;
            }
        }
    }
}

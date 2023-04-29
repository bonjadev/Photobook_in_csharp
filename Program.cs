using System;

namespace c__Photobook
{
    public class PhotoBook
    {

        //Photobook C# primer
        protected int numPages;

        public PhotoBook() //konstruktor postavlja vrednost broj stranica na 16
        {
            numPages = 16; //default broj stranica 
        }
        public PhotoBook(int numPages) //dodatni konstruktor
        {
            this.numPages = numPages;
        }

        public int getNumPages() //metoda
        {
            return numPages;
        }


    }

    public class SuperPhotoBook : PhotoBook
    {
        public SuperPhotoBook()
        {
            numPages = 64; //postavljanje vrednosti broja stranica sa konstruktorom na 64
        }

    }


    public class PhotoBookTest
    {
        public static void Main()
        {
            PhotoBook myAlbum1 = new PhotoBook(); //kreiranje objekta 1
            Console.WriteLine(myAlbum1.getNumPages());

            PhotoBook myAlbum2 = new PhotoBook(24); //kreiranje objekta 2 i postavljanje parametra broja stranice na 24
            Console.WriteLine(myAlbum2.getNumPages());

            SuperPhotoBook myBigPhotoAlbum1 = new SuperPhotoBook(); //kreiranje objekta 3
            Console.WriteLine(myBigPhotoAlbum1.getNumPages());
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder movie = new Folder("Movie");
            Folder actionmovie = new Folder("action");
            Folder comedymovie = new Folder("comedy");
            Folder actionComedy = new Folder("actionComedy");

            FIle Golmal = new FIle("Golmal", 100, "mp4");
            FIle Dhoom = new FIle("Dhoom", 100, "mp4");
            FIle Spectra = new FIle("Spectra", 100, "mp4");

            movie.CreteInitialFolder(movie);
           StringBuilder addressofactioncomedymovie= movie.Addfolder(actionComedy);
            StringBuilder addressofcomedymovie=  movie.Addfolder(comedymovie);
            StringBuilder addressofactionmovie= movie.Addfolder(actionmovie);
            


            actionComedy.Addfile(addressofactioncomedymovie,Dhoom);
            actionmovie.Addfile(addressofactionmovie,Spectra);
            comedymovie.Addfile(addressofcomedymovie,Golmal);
            Console.Read();
        }
    }
}

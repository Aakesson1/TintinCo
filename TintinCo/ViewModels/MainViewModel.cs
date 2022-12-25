using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TintinCo_.Model;

namespace TintinCo_.ViewModels
{

        public class MainViewModel
        {
            public ObservableCollection<Comic> Comics { get; set; } = new ObservableCollection<Comic>();
            private ComicRepository ComicRepository { get; set; }


            public MainViewModel()
            {
                ComicRepository = new ComicRepository();
                Comics = new ObservableCollection<Comic>(ComicRepository.comicRepository);
            }
        public List<Comic> searchRepoReleaseYear(string MinReleaseYear, string MaxReleaseYear)
        {

            List<Comic> Comicslist =
                (from tempComic in Comics
                 where tempComic.ReleaseYear.CompareTo(int.Parse(MinReleaseYear)) >= 0 && tempComic.ReleaseYear.CompareTo(int.Parse(MaxReleaseYear)) <= 0
                 select tempComic).ToList();
            return Comicslist;
        }
        public void AddComicToRepo(Comic comic)
        {
            Comics.Add(comic);
        }
        public void UpdateComicInRepo(Comic comic)
        {
            Comics.Add(comic);
        
        }
 

    }

}

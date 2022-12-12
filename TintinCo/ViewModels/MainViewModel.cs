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
        public List<Comic> searchRepoReleaseYear(string MinHdIndex, string MaxHdIndex)
        {

            List<Comic> Comicslist =
                (from tempDog in Comics
                 where tempDog.ReleaseYear.CompareTo(int.Parse(MinHdIndex)) >= 0 && tempDog.ReleaseYear.CompareTo(int.Parse(MaxHdIndex)) <= 0
                 select tempDog).ToList();
            return Comicslist;
        }
        public void AddComicToRepo(Comic comic)
        {
            Comics.Add(comic);
        }

        private void Dogs_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                int newIndex = e.NewStartingIndex;
                ComicRepository.AddComic(Comics[newIndex]);
            }
        }

    }

}

namespace MauiControls.ViewModels
{
    using System.Collections.ObjectModel;
    using MauiControls.Models;

    public class PhotoViewModel
    {
        public ObservableCollection<Photo> photos { get; private set; }

        public ObservableCollection<Photo> Photos 
        {
            get { return photos; }
            set { photos = value; }
        }

        public PhotoViewModel()
        {
            Photos = new ObservableCollection<Photo>
            {
                new Photo { Name = "Andromeda", ImageUrl = "galaxy1.jpg" },
                new Photo { Name = "Milky Way", ImageUrl = "galaxy2.jpg" },
                new Photo { Name = "Universe", ImageUrl = "galaxy3.jpg" },
                new Photo { Name = "Galaxy", ImageUrl = "galaxy4.jpg" },
                new Photo { Name = "Sombrero", ImageUrl = "galaxy5.jpg" }
            };
        }
    }
}

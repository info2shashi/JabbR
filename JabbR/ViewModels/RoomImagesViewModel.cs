using System.Collections.Generic;
using JabbR.Models;

namespace JabbR.ViewModels
{
    public class RoomImagesViewModel
    {

        public RoomImagesViewModel(RoomImages roomImages)
        {
            ImageName = roomImages.ImageName;
            ImageSource = roomImages.ImageSource;
            BigImageSource = roomImages.BigImageSource;
            Comment = roomImages.Comment;
        }
        
        public string ImageName { get; set; }

        public string ImageSource { get; set; }

        public string BigImageSource { get; set; }

        public string Comment { get; set; }
    }
}
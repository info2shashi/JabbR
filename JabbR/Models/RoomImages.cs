using System.ComponentModel.DataAnnotations;

namespace JabbR.Models
{
    public class RoomImages
    {
        [Key]
        public int Key { get; set; }

        public int UserKey { get; set; }
        public virtual ChatUser User { get; set; }

        public int RoomKey { get; set; }
        public virtual ChatRoom Room { get; set; }

        public string ImageName { get; set; }

        public string ImageSource { get; set; }

        public string BigImageSource { get; set; }

        public string Comment { get; set; }

    }
}
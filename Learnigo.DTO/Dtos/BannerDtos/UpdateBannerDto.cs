using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnigo.DTO.Dtos.BannerDtos
{
    public class UpdateBannerDto
    {
        public int BannerId { get; set; }
        public string title { get; set; }
        public string ImageUrl { get; set; }
    }
}

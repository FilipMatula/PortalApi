﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class ModelPhotoThumbnailDto
    {
        public int Id { get; set; }
        public ModelShortDto Model { get; set; }
        public string ImgSrc { get; set; }
    }
}

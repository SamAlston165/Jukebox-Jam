﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IImageSearch
    {
        Image GetAlbumArt(string artist, string album);
    }
}

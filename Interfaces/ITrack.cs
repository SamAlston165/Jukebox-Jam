using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITrack
    {
        string Artist { get; }
        string Title { get; }
        string Album { get; }
        string Genre { get; }
        string Year { get; }

        string GetPath();
    }
}

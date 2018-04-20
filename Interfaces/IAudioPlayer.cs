using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IAudioPlayer
    {
        void LoadTrack(string path);
        void Play();
        void Pause();
        void Stop();
    }
}

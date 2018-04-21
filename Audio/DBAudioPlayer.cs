using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio
{
    public class DBAudioPlayer : IAudioPlayer
    {
        private string host;
        private IAudioPlayer audioplayer;

        public DBAudioPlayer(IAudioPlayer audioPlayer, string hostAddr, int port)
        {
            this.audioplayer = audioPlayer;
            host = $"{hostAddr}:{port.ToString()}";
        }

        public void LoadTrack(string path)
        {
            audioplayer.LoadTrack(host + path);
        }

        public void Pause()
        {
            audioplayer.Pause();
        }

        public void Play()
        {
            audioplayer.Play();
        }

        public void Stop()
        {
            audioplayer.Stop();
        }
    }
}

using Interfaces;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio
{
    public class AudioPlayer : IAudioPlayer
    {
        private enum PlaybackState { Playing, Paused, Stopped }
        private PlaybackState _playbackState;

        private WaveOutEvent _player;
        private MediaFoundationReader _reader;

        public AudioPlayer()
        {
            _player = new WaveOutEvent();
            _playbackState = PlaybackState.Stopped;
        }

        public void LoadTrack(string url)
        {
            Stop();
            _reader = new MediaFoundationReader(url);
            _player.Init(_reader);
        }

        public void Play()
        {
            _player.Play();
            _playbackState = PlaybackState.Playing;
        }

        public void Pause()
        {
            if (_playbackState == PlaybackState.Paused)
            {
                _player.Play();
                _playbackState = PlaybackState.Playing;
            }
            else if (_playbackState == PlaybackState.Playing)
            {
                _player.Pause();
                _playbackState = PlaybackState.Paused;
            }
        }

        public void Stop()
        {
            _player.Stop();
            _player.Dispose();
            _playbackState = PlaybackState.Stopped;
        }
    }
}

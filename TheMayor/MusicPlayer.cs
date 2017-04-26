using System;
using System.Threading.Tasks;
using WMPLib;

namespace TheMayor
{
    internal class MusicPlayer
    {
        public WindowsMediaPlayer wplayer;
        public MusicPlayer()
        {
            
            WindowsMediaPlayer _wplayer = new WindowsMediaPlayer();
            wplayer = _wplayer;
        }

        internal void PlayMile()
        {
            this.wplayer.URL = "Mile.mp3";
        }
        internal void PlayAlisia()
        {
            this.wplayer.URL = "Alisia.mp3";
        }
    }
}
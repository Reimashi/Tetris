using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    using System;
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using System.Threading;
    using System.IO;

    public class Sound
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        
        public Sound(Stream stream)
        {
            player.Stream = stream;
        }

        public void Play()
        {
            Play(false);
        }

        public void Play(Boolean looping)
        {
            if (looping)
            {
                player.PlayLooping();
            }
            else
            {
                player.Play();
            }
        }

        public void Stop()
        {
            player.Stop();
        }
    }
}

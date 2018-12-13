using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace JumpMaid
{
    class Sound
    {
        public void Sound_Startbildschrim()
        {
            SoundPlayer sp = new SoundPlayer(JumpMaid.Properties.Resources._06_Blueroom);
            sp.Play();
        }
    }
}

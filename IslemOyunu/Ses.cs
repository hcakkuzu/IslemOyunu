using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace IslemOyunu
{
    public class Ses
    {
        
        public static void Click_Play()
        {
            SoundPlayer click = new SoundPlayer();
            click.SoundLocation = "Sounds//click.wav";
            click.Play();
        }

        public static void sesCal(string x)
        {
            SoundPlayer click = new SoundPlayer();
            click.SoundLocation = "Sounds//"+x;
            click.Play();
        }

    }
}

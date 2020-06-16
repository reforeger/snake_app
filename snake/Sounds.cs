﻿using System;
using Snake_N2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Sounds
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;

        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
        }

        public void Play()
        {
            player.URL = pathToMedia + "stardust.mp3";
            player.settings.volume = 30;
            player.controls.play();
            player.settings.setMode("loop", true);
        }

        public void Play(string songName)
        {
            player.URL = pathToMedia + songName + ".mp3";
            player.controls.play();
        }

        public void PlayEat()
        {
            player.URL = pathToMedia + "click.mp3";
            player.settings.volume = 100;
            player.controls.play();
        }
    }
}

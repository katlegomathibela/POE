using System;
using System.IO;
using System.Media;

namespace POE
{
    public class voice_greeting
    {
        public void greet()
        {
            string auto_path = AppDomain.CurrentDomain.BaseDirectory;
            string full_path = Path.Combine(auto_path, "greeting.wav");

            SoundPlayer greetMe = new SoundPlayer(full_path);
            greetMe.Play();
        }
    }
}

using System;
using System.IO;
using System.Media;

namespace PROGassignment
{
    public class BootManager
    {
        private string _targetFile;

        public BootManager()
        {
            string root = AppDomain.CurrentDomain.BaseDirectory;

            // ✅ Match your actual file name
            _targetFile = Path.Combine(root, "greeting.wav");
        }

        public void PlayStartupSound()
        {
            ExecuteVocalSequence(_targetFile);
        }

        public void ExecuteVocalSequence(string location)
        {
            try
            {
                if (File.Exists(location))
                {
                    using (SoundPlayer audioPlayer = new SoundPlayer(location))
                    {
                        // ✅ Ensures sound fully plays
                        audioPlayer.PlaySync();
                    }
                }
                else
                {
                    Console.WriteLine($">> Audio file not found: {location}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($">> System Audio Link: {ex.Message}");
            }
        }
    }
}
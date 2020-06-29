using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace TTSDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Speak("All we need to do is to make sure we keep talking");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

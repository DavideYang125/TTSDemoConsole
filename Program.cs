using System;
using System.Collections.Generic;
using System.IO;
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
            synthesizer.SetOutputToWaveFile(@"D:\tts\en_1.wav");
            var content = File.ReadAllText(@"D:\tts\v.txt", Encoding.UTF8);

            synthesizer.SelectVoice("Microsoft Huihui Desktop");
            synthesizer.SetOutputToWaveFile(@"D:\tts\cn_1.wav");
            synthesizer.Speak("你好，早上好，");
            synthesizer.SetOutputToWaveFile(@"D:\tts\cn_2.wav");
            synthesizer.Speak(content);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

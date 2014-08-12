using Windows.Phone.Speech.Synthesis;

namespace UnityNativeToolsWP8
{
    public class Speech
    {
        public static void SayText(string text)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SpeakTextAsync(text);
        }
    }
}

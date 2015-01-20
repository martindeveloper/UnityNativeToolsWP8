using System;
using Microsoft.Phone.Tasks;

namespace UnityNativeToolsWP8
{
    public class Media
    {
        public static void PlayVideoFromStreamingAssets(string file)
        {
            var mediaPlayerLauncher = new MediaPlayerLauncher
            {
                Media = new Uri("Data/StreamingAssets/" + file, UriKind.RelativeOrAbsolute),
                Location = MediaLocationType.Install,
                Controls = MediaPlaybackControls.Pause | MediaPlaybackControls.Stop,
                Orientation = MediaPlayerOrientation.Landscape
            };

            mediaPlayerLauncher.Show();
        }
    }
}

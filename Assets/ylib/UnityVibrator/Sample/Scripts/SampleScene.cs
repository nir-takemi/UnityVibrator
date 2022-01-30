using UnityEngine;

namespace ylib.UnityVivrator
{

    public class SampleScene : MonoBehaviour
    {
        public void PlayVeryShort()
        {
            ylib.Services.UnityVibrator.PlayVeryShort();
        }
        public void PlayShort()
        {
            ylib.Services.UnityVibrator.PlayShort();
        }
        public void Play()
        {
            ylib.Services.UnityVibrator.Play();
        }
        public void PlayLong()
        {
            ylib.Services.UnityVibrator.PlayLong();
        }
        public void PlayVeryLong()
        {
            ylib.Services.UnityVibrator.PlayVeryLong();
        }
    }
}

using UnityEngine;
using System.Runtime.InteropServices;

namespace ylib
{

    public static class UnityVibrator
    {

        public static void PlayVeryShort()
        {
            Play(1519, 1);
        }
        public static void PlayShort()
        {
            Play(1521, 20);
        }
        public static void Play()
        {
            Play(1350, 200);
        }
        public static void PlayLong()
        {
            Play(1351, 500);
        }
        public static void PlayVeryLong()
        {
            Play(4095, 900);
        }

        public static void Play(int soundId, long millisec)
        {
            if (SystemInfo.supportsVibration)
            {
#if !UNITY_EDITOR
#if UNITY_IOS
            PlaySystemSound(soundId);
#elif UNITY_ANDROID
            Vibrate(millisec);
#endif
#endif
            }
        }

        #region iOS
#if !UNITY_EDITOR && UNITY_IOS
        [DllImport ("__Internal")]
        static extern void _playSystemSound(int soundId);

        public static void PlaySystemSound(int soundId)
        {
            _playSystemSound(soundId);
        }


#endif
        #endregion


        #region Android
#if !UNITY_EDITOR && UNITY_ANDROID
        public static AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        public static AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        public static AndroidJavaObject vibrator = currentActivity.Call<AndroidJavaObject>("getSystemService", "vibrator");

        // android.permission.VIBRATEを雑に付与するための定義
        private static void _permission(){ Handheld.Vibrate(); }

        public static void Vibrate(long millisec)
        {
            vibrator.Call("vibrate", millisec);
        }
#endif
        #endregion
    }
}

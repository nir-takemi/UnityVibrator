# UnityVibrator
Unityでモバイルアプリ向けのバイブレーションを簡易に実装するためのアセット

# 対象ビルド
- iOS
- Android

# 準備
## unitypackageのDL
以下から最新のものをダウンロードしてください  
https://github.com/nir-takemi/UnityVibrator/releases

# 実装
1. DLした.unitypackageをmenuからimport
![image](https://user-images.githubusercontent.com/10418442/68995076-22992080-08cd-11ea-8c88-e435b6d40dd4.png)

2. Sampleは任意で、その他にチェックがされていることを確認の上import
![image](https://user-images.githubusercontent.com/10418442/151666419-2f15de60-422d-4803-aaa5-726d60a34bb5.png)

3. コード上で以下のように処理を書く
```C#
// 5パターンの定義済のバイブレーションを再生することができます
ylib.Services.UnityVibrator.PlayVeryShort();
ylib.Services.UnityVibrator.PlayShort();
ylib.Services.UnityVibrator.Play();
ylib.Services.UnityVibrator.PlayLong();
ylib.Services.UnityVibrator.PlayVeryLong();

// オリジナルのパターンを利用したい場合は以下のように再生することができません
// [iOS]SoundId: https://iphonedev.wiki/index.php/AudioServices
// [Android]millisec: ミリ秒指定
ylib.Services.UnityVibrator.Play(1000, 500);
```

# その他
- オリジナルのパターンを利用したい場合
  - 以下のアプリ（シンプル振動確認）でiOSはSoundId、Androidはミリ秒でのパターンを確認することが可能です。  
  [<img src="https://user-images.githubusercontent.com/10418442/151706245-695fd074-9441-4043-8c07-63bb75cbd11d.png" height="50">](https://apps.apple.com/us/app/%E3%82%B7%E3%83%B3%E3%83%97%E3%83%AB%E6%8C%AF%E5%8B%95%E7%A2%BA%E8%AA%8D/id1604219797)  [<img src="https://user-images.githubusercontent.com/10418442/151706249-a093e904-9e21-49d2-9562-e3f121642e75.png" height="50">](https://play.google.com/store/apps/details?id=jp.Yasuragitei.VibrationChecker)



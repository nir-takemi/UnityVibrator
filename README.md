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
ylib.UnityVibrator.PlayVeryShort();
ylib.UnityVibrator.PlayShort();
ylib.UnityVibrator.Play();
ylib.UnityVibrator.PlayLong();
ylib.UnityVibrator.PlayVeryLong();

// オリジナルのパターンを利用したい場合は以下のように再生することができません
// [iOS]SoundId: https://iphonedev.wiki/index.php/AudioServices
// [Android]millisec: ミリ秒指定
ylib.UnityVibrator.Play(1000, 500);
```

# その他
- オリジナルのパターンを利用したい場合
  - 以下のアプリでiOSはSoundId、Androidはミリ秒でのパターンを確認することが可能です。

  [<img src="https://d6scj24zvfbbo.cloudfront.net/8dc6156202f015e51f24d5a7837f8ecc/200000005-70bad70bae/200/img_ios.png" height="55">](https://apps.apple.com/us/app/%E3%82%B7%E3%83%B3%E3%83%97%E3%83%AB%E6%8C%AF%E5%8B%95%E7%A2%BA%E8%AA%8D/id1604219797)  [<img src="https://d6scj24zvfbbo.cloudfront.net/8dc6156202f015e51f24d5a7837f8ecc/200000001-200bf200c0/200/img_android.png" height="55">](https://play.google.com/store/apps/details?id=jp.Yasuragitei.VibrationChecker)



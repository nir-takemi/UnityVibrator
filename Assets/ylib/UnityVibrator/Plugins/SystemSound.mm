#import <Foundation/Foundation.h>
#import <AudioToolBox/AudioToolBox.h>

int vibrationCount = 0;

void _vibrateIntervaCallback(SystemSoundID soundId, void *clientData) {
    
    vibrationCount--;
    
    if (vibrationCount > 0) {
        AudioServicesPlaySystemSound(soundId);
    }
    else {
        AudioServicesRemoveSystemSoundCompletion(soundId);
    }
}

extern "C" void _playSystemSound (int soundId, int loopCount)
{
    // set loop count
    vibrationCount = loopCount;
    // set callback
    AudioServicesAddSystemSoundCompletion(soundId, NULL, NULL, _vibrateIntervaCallback, NULL);

    AudioServicesPlaySystemSound(soundId);
}

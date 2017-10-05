# Dota-2-Chat-Wheel-Soundboard
This is a small project to re-integrate chat wheel sounds to Dota 2.
I created a soundboard that will play all compendium chat wheel sounds via ingame voice chat to you and your teammates.

![Soundboard](https://github.com/derdanielb/Dota-2-Chat-Wheel-Soundboard/raw/master/readme/application.png "Soundboard")

## Installation
For this setup we need two downloads. The soundboard and an audio driver.
### Downloads

1. Download the precompiled [Chat Wheel Soundboard](https://github.com/derdanielb/Dota-2-Chat-Wheel-Soundboard/releases/download/1.0/ChatWheelSoundboard.zip)
2. Download the tool [VB-Audio Virtual Cable](https://www.vb-audio.com/Cable/index.htm#DownloadCable)
(Any other audio tool that can send playback sound to a recording device will work)

### Setup

*Please remember your previous settings if change anything.*

1. __Install the **VB-Audio Virtual Cable**:__ 
Setup requires to be run in Administrator Mode. Please refer to Tool Documentation.
NOTE: Any other audio tool that can emulate playback sound to a recording source will work aswell.


2. __Change your steam voice recording device:__
Go to your Steam Settings>Voice> click 'Change device'. Windows sound manager will popup. 

![Steam settings](https://github.com/derdanielb/Dota-2-Chat-Wheel-Soundboard/raw/master/readme/steam_audio.png "Steam settings")


3. __Set virtual cable as default:__
Set **'CABLE Output'** as your *standard device* and also as *standard communication device*
![Windows sound manager](https://github.com/derdanielb/Dota-2-Chat-Wheel-Soundboard/raw/master/readme/windows_sound.png "Windows sound manager")

When you are done, in *Steam>Settings>Voice* click *Detect Audio devices*. This should set you steam recording device to 'CABLE Output' as it can be seen in step 2). 


4. __Start ChatWheelSoundboard.exe:__
Figure our the correct 'Mic device' on the left hand side of the soundbar.
Usually the largest number is the most recently installed device (which should be the virtual cable tool).
You can check your selection by watching the indicator bar at windows sound manager (step 3) or steam microphone test (step 2).

5. __Enable Dota 2 open microphone:__
Start Dota 2. Go to Settings>Audio>Voice: Select 'Open Mic' for team voice chat.
![Dota 2 voice](https://github.com/derdanielb/Dota-2-Chat-Wheel-Soundboard/raw/master/readme/dota2_audiosetting_s.png "Dota 2 voice")

## Requirements
- .NET 4.5.2
- Audio tool to send sound from playback source to recording source. I recommend [VB-Audio Virtual Cable](https://www.vb-audio.com/Cable/index.htm#DownloadCable).

## Limitations
It is not possible to use your mircophone and soundboard at the same time, since both require to be steams recording device.

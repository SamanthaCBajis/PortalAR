# PortalAR
<br /> An example video of this application can be found on my [YouTube Channel.](https://www.youtube.com/watch?v=efhcD0uHics "YouTube")
<br />
<br />This respository contains a Unity/ARKit application. **_PortalAR_** is an experience where the user can enter a new world just by walking through the doorway in front of them! By tapping the screen the user has the power to enter and exit the portal as many times as they would like; also they have the ability to place the portal door anywhere in the room or space around them. **_PortalAR_** was made possible by a tutorial offered on MatthewHallberg's YouTube Channel. (the link to his video will be in the acknowledgements below) 
<br />
<br /> 

## Getting Started

### Prerequisites
This is the software needed in order to build and run this app on your own mobile device:
<br />
<br /> • The [Unity Engine](https://unity3d.com/get-unity/download/archive "Unity 3D download"). Version 2017.3.0.
<br />
- App can only run on iOS! You will need an iOS device along with the latest version of [Xcode](https://developer.apple.com/download/ "Xcode 9.3 Beta").
- NOTE! You will need to create an [Apple ID](https://appleid.apple.com/account#!&page=create "Developer Account") in order to use Xcode and build this app to device.
- NOTE! Make sure to have the latest software version on your phone.

### Installing
Instructions to get **_PortalAR_** your own mobile device:
<br />
<br /> • In **_PortalAR's_** repo, click the green button "Clone or download" and then click "Download Zip".
<br />
<br /> • Once the Zip File has loaded to your desktop double click the zip file to open it. Navigate to Assets > PortalAR.unity and then double click that scene to open it in Unity.
<br />
<br /> -NOTE! The PortalAR.unity scene may not be located at the top of the Assets folder. If not, you will have to scroll through the folder to find it. It will be titled exactly PortalAR.unity with the Unity logo-
<br />
<br /> After opening the scene in Unity you will build the app to your phone.
<br />
- For iOS builds:
   - Go to the top left of your desktop to File > Build Settings and switch the platform to iOS. (switching the platform can take a while so be patient!) Then click the Player Settings button below. With this open you can change the name of the application or bundle identifier, if you would like to change them, and then press Build and Run to then be prompted to name your build and save it. (I usually save the build to my desktop so I can delete it later) 
     - The build will open in Xcode. Before proceeding to add it to your phone make sure to check your Apple ID is correct and the bundle identifier and the name of the application is what you would like it to be. Then press the play button in the top left corner of Xcode and this application will build and run directly to your iOS device!

### Deployment
A few important things to note before building this app:
<br />
<br /> • In Player Settings, you are not only able to change the name of the application and bundle identifier to whatever you would like them to be, you can also add a photo to be the icon for the application on your phone. These are the very first things you can change in Player Settings.
<br /> • ARKit tracks your head movement. Meaning, wherever the phone is facing, the application will open and start from that position. If you would like to be facing a certain direction to play the app right after building to your phone I would suggest facing your device in that direction so you can start the experience in the most comfortable position for the best experience.


## How to play
The instructions to play the application **_PortalAR_**:
<br />
<br /> • The best way to begin would be to wait for the camera to focus. Then, move the phone over the floor or objects near you to have the app begin tracking the space around you. (You do not need to be really close! You will know its working when the golden Point Cloud Particles begin to show)
<br />
<br />
<br /> 
<br /> • Tap anywhere on the screen and the door will appear. Tap as many times as you would like to position the doorway in the best place for you to walk through. (The doorway does not have to be perfectly positioned in front of you, just walking through the door anywhere you place it will work)
<br />
<br /> • Once you enter the portal the world around you will change just like that! You will be able to see the doorway you entered. You can enter or exit as much as you would like as well as tap the screen to move the doorway to another area in the space.
<br />
<br /> 

# Authors
• Samantha Cayla Bajis - _Initial work_ - SamBajis

# Acknowledgments
To make **_PortalAR_** possible:
<br /> 
<br /> • ARKit - Applications set up and code for all scripts, shaders, objects, particles used to create the portal doorway
<br /> 
<br /> • MatthewHallberg's YouTube Channel - the tutorial on how to make this application. It is super cool and informative! Check it out here [AUGMENTED REALITY Tutorial: ARKit portal to the Upside Down](https://www.youtube.com/watch?v=Z5AmqMuNi08 "YouTube")
<br /> 
<br /> • Unity Engine and Unitys Built in Shaders - Unity is the base for creating the entirety of the app. The built in shaders were downloaded from Unitys archive page and modified to create the portal

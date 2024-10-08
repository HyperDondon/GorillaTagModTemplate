# Gorilla Tag Mod Template (Changes by HyperDondon)

.NET Project Template for PCVR Gorilla Tag Mods


The template creates the following files of note:
* [Plugin.cs](GorillaTagModTemplateProject/Plugin.cs): The main class of your mod. Most of your code should go here.
* [PluginInfo.cs](GorillaTagModTemplateProject/PluginInfo.cs): This holds information about your plugin in a central location. This is where the plugin name, id, and version are stored.
* [HarmonyPatches.cs](GorillaTagModTemplateProject/HarmonyPatches.cs): This handles the application of harmony patches (such as ExamplePatch). You shouldn't need to modify this class.
* [Patches/ExamplePatch.cs](GorillaTagModTemplateProject/Patches/ExamplePatch.cs): This demonstrates how patches are created, you should remove or modify it as you see fit.
* [MakeRelease.ps1](GorillaTagModTemplateProject/MakeRelease.ps1): This script generates a [MonkeModManager](https://github.com/DeadlyKitten/MonkeModManager/) compatible release (named ModName-v.zip). You should use this to create builds that you share with others.
* [Directory.Build.props](GorillaTagModTemplateProject/Directory.Build.props): This file contains information about where dependencies are located. If you are getting CS024 (type could not be found) errors, GamePath is probably wrong. 
* [GorillaTagModTemplateProject.sln](GorillaTagModTemplateProject.sln): This file contains information about where dependencies are located. If you are getting CS024 (type could not be found) errors, GamePath is probably wrong. 
# Building

## Step 1
Open [GorillaTagModTemplateProject.sln](GorillaTagModTemplateProject.sln) in Visual Studio

## Step 2
Change the game directory in [Directory.Build.props](GorillaTagModTemplateProject/Directory.Build.props) to your actual Gorilla Tag directory.

## Step 3
![image](https://github.com/user-attachments/assets/2af451ab-98e1-4ff7-8ec7-9cba3728bbb4)

## Step 4
![image](https://github.com/user-attachments/assets/1c63c50d-66ef-4357-957b-cac8df1e54db)

## Step 5
The .dll is now in GorillaTagModTemplateProject/bin/Release/netstandard2.1/


### This product is not affiliated with Gorilla Tag or Another Axiom LLC and is not endorsed or otherwise sponsored by Another Axiom LLC. Portions of the materials contained herein are property of Another Axiom LLC. © 2021 Another Axiom LLC.



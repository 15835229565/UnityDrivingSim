# UnityDrivingSim
A driving simulator created for Self Driving Car research.

This repository contains code for a simulator which is being created for the purpose of collecting data for the training of deep neural networks which can be applied to autonomous vehicles. At present, it is a prototype simulator for use in creating novel driving scenes. For more information, see our paper [Beyond Grand Theft Auto V for Training, Testing, and Enhancing Deep Learning in Self Driving Cars](https://princetonautonomous.github.io/)

This work follows from Christopher Hay (Princeton '17) in his paper Training of Vehicle Perception via Stochastic Simulation. 
My work is being conducted under Professor Kornhauser.

The project currently requires the assets EasyRoads3D Pro and Gaia from the Unity asset store. Since I do not own these assets, I have not uploaded them to the repository. If you wish to extend this work, those assets should be purchased and imported into the Unity project.

To run the project, you must sign up for an API key from [Mapzen](https://mapzen.com/), and change the DownloadMapData.cs file to use that API key. Also, you must change the path to cache tile data in CacheTileData.cs to a folder of your choosing.
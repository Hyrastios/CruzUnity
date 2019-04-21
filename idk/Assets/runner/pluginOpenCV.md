# PluginOpenCV

Ce plugin a été réalisé en suivant chaque étape du tutoriel donné par **Thomas Mountainborn** disponible ici:
https://forum.unity.com/threads/tutorial-using-c-opencv-within-unity.459434/ et avec [OpenCV4.0.1](https://opencv.org/releases/) en C++.

## Contenu du plugin

Celui-ci contient toutes les librairies que nous avons besoin pour la détection de mouvement dans le script project1.dll.
Celui-ci codé en C++ défini la struct Circle ainsi que la fonction detect qui permettra de déterminer la position
du visage du joueur à partir de [lbpcascade_frontalface.xml](idk/lbpcascade_frontalface.xml) et permet de transformer ces données de manière à les utilisés avec Unity.

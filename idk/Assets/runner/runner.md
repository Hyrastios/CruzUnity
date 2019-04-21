# Runner

L'objectif de ce jeu est de tenir le plus longtemps possible en esquivant les vagues de crabes qui veulent s'en 
prendre au petit ballon que vous contrôlez. 

## Fonctionnalités
 * chronomètre servant de score.
 * écran de pause.
 * menu principal accessible.
 * contrôle du ballon via la détection de mouvement( voir [pluginOpenCV.md](pluginOpenCV.md) pour plus d'informations)

## Assets et Script utilisés
Ce jeu utilise les mêmes assets graphiques que le jeu du Ballon à savoir:
 * https://assetstore.unity.com/packages/3d/vegetation/cartoon-palmtree-and-umbrellas-58457
 * https://assetstore.unity.com/packages/3d/vegetation/trees/yughues-free-palm-trees-13540

Le contrôle par détection de mouvement se fait en récupérant la position de la tête du joueur dans le script 
[OpenCVFaceDetection.cs](script/OpenCVFaceDetection.cs) à partir d'une structure appelée Circle qui nous permet de récupérer les coordonnées de position du visage du joueur par rapport à la caméra, cela se passe dans [PositionFaces.cs](script/OpenCVFaceDetection.cs).

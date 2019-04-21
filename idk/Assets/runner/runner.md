# Runner

L'objectif de ce jeu est de tenir le plus longtemps possible en esquivant les vagues de crabes qui veulent s'en 
prendre au petit ballon que vous contrôlez. 

## Fonctionnalités
 * Timer servant de score.
 * écran de pause.
 * menu principal accessible.
 * contrôle du ballon via la détection de mouvement( voir [pluginOpenCV.md](idk/Assets/runner/pluginOpenCV.md) pour plus d'information)

## Assets et Script utilisés
Ce jeu utilise les mêmes assets graphique que le jeu du Ballon à savoir:
 * https://assetstore.unity.com/packages/3d/vegetation/cartoon-palmtree-and-umbrellas-58457
 * https://assetstore.unity.com/packages/3d/vegetation/trees/yughues-free-palm-trees-13540

Le contrôle par détection de mouvement se fait en récupérant la position de la tête du joueur dans le script 
[OpenCVFaceDetection.cs](idk/Assets/runner/script/OpenCVFaceDetection.cs) à partir d'une struct appelée Circle, puis à partir de cette structure nous pouvons
déplacer le ballon de gauche à droite à partir de la position x,y du cercle sur la webcam dans [PositionFaces.cs](idk/Assets/runner/script/OpenCVFaceDetection.cs).

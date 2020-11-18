using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe qui gère les patterns d'attaque du boss
/// </summary>
public class BossBulletPatterns
{
    /// <summary>
    /// Permet d'obtenir une liste de balles selon un pattern choisi au hasard
    /// </summary>
    /// <returns>Liste des positions et orientations(angle de rotation de l'axe Z) de toutes les balles d'une attaque</returns>
    public static List<Vector4> getOneBulletPattern()
    {
        List<Vector4> bulletPositions = new List<Vector4>();

        double heightOffset = Screen.height * 0.1;
        float xSpawn, ySpawn = Screen.height - (float)heightOffset, zSpawn = 10;

        xSpawn = Screen.width / 2;
        //bulletPositions.Add(new Vector3(xSpawn, ySpawn, zSpawn));
        float xSpawnOffset = xSpawn / 26;
        //Même chance pour chaque attaque d'être choisie
        int randomPattern = Random.Range(0, 3);
        switch (randomPattern)
        {
            case 0:
                bulletPositions.Add(new Vector4(xSpawn, ySpawn, zSpawn, 0));
                bulletPositions.Add(new Vector4(xSpawn, ySpawn, zSpawn, -15));
                bulletPositions.Add(new Vector4(xSpawn, ySpawn, zSpawn, -30));
                bulletPositions.Add(new Vector4(xSpawn, ySpawn, zSpawn, -45));
                bulletPositions.Add(new Vector4(xSpawn, ySpawn, zSpawn, -60));
                bulletPositions.Add(new Vector4(xSpawn, ySpawn, zSpawn, -75));
                bulletPositions.Add(new Vector4(xSpawn, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn, ySpawn, zSpawn, -105));
                bulletPositions.Add(new Vector4(xSpawn, ySpawn, zSpawn, -120));
                bulletPositions.Add(new Vector4(xSpawn, ySpawn, zSpawn, -135));
                bulletPositions.Add(new Vector4(xSpawn, ySpawn, zSpawn, -150));
                bulletPositions.Add(new Vector4(xSpawn, ySpawn, zSpawn, -165));
                bulletPositions.Add(new Vector4(xSpawn, ySpawn, zSpawn, -180));
                break;
            case 1:
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 2, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 3, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 4, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 5, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 6, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 7, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 8, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 9, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 10, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 11, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 12, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 13, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 14, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 15, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 16, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 17, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 18, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 19, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 20, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 21, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 22, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 23, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 24, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 25, ySpawn, zSpawn, -90));

                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 2, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 3, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 4, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 5, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 6, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 7, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 8, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 9, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 10, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 11, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 12, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 13, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 14, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 15, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 16, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 17, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 18, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 19, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 20, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 21, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 22, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 23, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 24, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 25, ySpawn + 100.0f, zSpawn, -90));

                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 2, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 3, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 4, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 5, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 6, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 7, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 8, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 9, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 10, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 11, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 12, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 13, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 14, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 15, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 16, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 17, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 18, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 19, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 20, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 21, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 22, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 23, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 24, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 25, ySpawn + 200.0f, zSpawn, -90));

                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 2, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 3, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 4, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 5, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 6, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 7, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 8, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 9, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 10, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 11, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 12, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 13, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 14, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 15, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 16, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 17, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 18, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 19, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 20, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 21, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 22, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 23, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 24, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn - xSpawnOffset * 25, ySpawn + 300.0f, zSpawn, -90));
                break;
            case 2:
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 2, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 3, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 4, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 5, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 6, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 7, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 8, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 9, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 10, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 11, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 12, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 13, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 14, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 15, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 16, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 17, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 18, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 19, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 20, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 21, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 22, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 23, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 24, ySpawn, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 25, ySpawn, zSpawn, -90));

                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 2, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 3, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 4, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 5, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 6, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 7, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 8, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 9, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 10, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 11, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 12, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 13, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 14, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 15, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 16, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 17, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 18, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 19, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 20, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 21, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 22, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 23, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 24, ySpawn + 100.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 25, ySpawn + 100.0f, zSpawn, -90));

                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 2, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 3, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 4, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 5, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 6, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 7, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 8, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 9, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 10, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 11, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 12, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 13, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 14, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 15, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 16, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 17, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 18, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 19, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 20, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 21, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 22, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 23, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 24, ySpawn + 200.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 25, ySpawn + 200.0f, zSpawn, -90));

                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 2, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 3, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 4, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 5, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 6, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 7, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 8, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 9, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 10, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 11, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 12, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 13, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 14, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 15, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 16, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 17, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 18, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 19, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 20, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 21, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 22, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 23, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 24, ySpawn + 300.0f, zSpawn, -90));
                bulletPositions.Add(new Vector4(xSpawn + xSpawnOffset * 25, ySpawn + 300.0f, zSpawn, -90));
                break;

        }

        return bulletPositions;
    }
}

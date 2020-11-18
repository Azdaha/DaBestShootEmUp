using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe qui donne les patterns d'ennemis
/// </summary>
public class EnnemiesPattern
{
    /// <summary>
    /// Permet de générer une formation d'ennemi (composée de 1 ou plusieurs individus)
    /// </summary>
    /// <returns>List des emplacements des ennemis pour ce pattern</returns>
    public static List<Vector3> getOnePattern()
    {
        float randomPattern = Random.Range(0.0f, 1.0f);
        List<Vector3> ennemiesPositions = new List<Vector3>();

        double widthOffset = Screen.width * 0.05;
        double heightOffset = Screen.height * 0.1;
        float xSpawn, ySpawn = Screen.height + (float)heightOffset, zSpawn = 10;

        //On s'assure avec les offset que l'ennemi spawn en dehors de l'écran en haut mais bien dans l'écran au niveau de la largeur
        xSpawn = Random.Range(0 + (float)widthOffset, Screen.width - (float)widthOffset);
        ennemiesPositions.Add(new Vector3(xSpawn, ySpawn, zSpawn));//Il y a forcément au moins 1 ennemis de base
        //if randomPattern < 0.20f -> Single ennemy already added   
        //20% de chance d'avoir une formation constituée de plusieurs ennemis
        if (randomPattern > 0.79f)//0.79f
        {
            //Multiple ennemies in formation to add
            int randomPatternIndex = Random.Range(0, 3);
            switch (randomPatternIndex)
            {
                case 0:
                    //Pyramidal formation
                    ennemiesPositions.Add(new Vector3(xSpawn - 50.0f, ySpawn + 50.0f, zSpawn));
                    ennemiesPositions.Add(new Vector3(xSpawn + 50.0f, ySpawn + 50.0f, zSpawn));
                    ennemiesPositions.Add(new Vector3(xSpawn, ySpawn + 100.0f, zSpawn));
                    ennemiesPositions.Add(new Vector3(xSpawn + 100.0f, ySpawn + 100.0f, zSpawn));
                    ennemiesPositions.Add(new Vector3(xSpawn - 100.0f, ySpawn + 100.0f, zSpawn));
                    break;
                case 1:
                    //Star formation
                    ennemiesPositions.Add(new Vector3(xSpawn - 75.0f, ySpawn, zSpawn));
                    ennemiesPositions.Add(new Vector3(xSpawn + 25.0f, ySpawn + 75.0f, zSpawn));
                    ennemiesPositions.Add(new Vector3(xSpawn - 100.0f, ySpawn + 75.0f, zSpawn));
                    ennemiesPositions.Add(new Vector3(xSpawn - 37.5f, ySpawn + 125.0f, zSpawn));
                    break;
                case 2:
                    //Heart formation
                    ennemiesPositions.Add(new Vector3(xSpawn - 50.0f, ySpawn + 50.0f, zSpawn));
                    ennemiesPositions.Add(new Vector3(xSpawn + 50.0f, ySpawn + 50.0f, zSpawn));
                    ennemiesPositions.Add(new Vector3(xSpawn - 100.0f, ySpawn + 100.0f, zSpawn));
                    ennemiesPositions.Add(new Vector3(xSpawn + 100.0f, ySpawn + 100.0f, zSpawn));
                    ennemiesPositions.Add(new Vector3(xSpawn - 125.0f, ySpawn + 150.0f, zSpawn));
                    ennemiesPositions.Add(new Vector3(xSpawn + 125.0f, ySpawn + 150.0f, zSpawn));

                    ennemiesPositions.Add(new Vector3(xSpawn - 75.0f, ySpawn + 200.0f, zSpawn));
                    ennemiesPositions.Add(new Vector3(xSpawn + 75.0f, ySpawn + 200.0f, zSpawn));

                    ennemiesPositions.Add(new Vector3(xSpawn, ySpawn + 150.0f, zSpawn));
                    break;
            }
            
        }
        return ennemiesPositions;
    }
}

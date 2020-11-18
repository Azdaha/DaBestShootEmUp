using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [Header("Asteroid object")]
    [SerializeField]
    Asteroid m_asteroid;

    [Header("Spawning parameter")]
    [SerializeField]
    float m_spawnDelay;

    private Camera m_mainCam;
    // Start is called before the first frame update
    void Start()
    {
        m_mainCam = Camera.main;
        StartCoroutine(asteroidSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Permet de gérer l'apparition des astéroïdes en arrière-plan. Ils peuvent apparaître de n'importe quelle direction
    /// </summary>
    /// <returns></returns>
    private IEnumerator asteroidSpawn()
    {
        while (Application.isPlaying)
        {
            yield return new WaitForSeconds(m_spawnDelay);

            double widthOffset = Screen.width * 0.05;
            double heightOffset = Screen.height * 0.1;
            //z=12
            float xSpawn = 0.0f, ySpawn = 0.0f, zSpawn = 12.0f;

            int direction = Random.Range(0, 4);
            m_asteroid.m_directionOrigin = direction;

            switch (direction)
            {
                case 0://Coming from upward
                    ySpawn = Screen.height + (float)heightOffset;
                    xSpawn = Random.Range(0 + (float)widthOffset, Screen.width - (float)widthOffset);
                    break;
                case 1://Coming from downward
                    ySpawn = -(float)heightOffset;
                    xSpawn = Random.Range(0 + (float)widthOffset, Screen.width - (float)widthOffset);
                    break;
                case 2://Coming from left
                    xSpawn = -(float)widthOffset;
                    ySpawn = Random.Range(0 + (float)heightOffset, Screen.height - (float)heightOffset);
                    break;
                case 3://Coming from right
                    xSpawn = Screen.width + (float)widthOffset;
                    ySpawn = Random.Range(0 + (float)heightOffset, Screen.height - (float)heightOffset);
                    break;
            }

            m_asteroid.transform.position = m_mainCam.ScreenToWorldPoint(new Vector3(xSpawn, ySpawn, zSpawn));
            Instantiate(m_asteroid);
        }
    }
}

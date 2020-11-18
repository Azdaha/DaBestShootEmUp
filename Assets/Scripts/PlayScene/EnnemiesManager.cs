using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesManager : MonoBehaviour
{

    [Header("Ennemy wave parameters")]
    [SerializeField]
    float m_spawnDelay;
    [SerializeField]
    float m_WaveDelay;
    [SerializeField]
    int m_EnnemyPerWave;
    [SerializeField]
    int m_wavesBeforeBoss;

    [Header("GameObject references")]
    [SerializeField]
    Player m_player;
    [SerializeField]
    GameObject m_ennemy;
    [SerializeField]
    GameObject m_boss;

    private Camera m_mainCamera;
    private int m_waveNumber;//Comptage des vagues avant le boss

    // Start is called before the first frame update
    void Start()
    {
        m_mainCamera = Camera.main;
        StartCoroutine(ennemySpawn());
        m_waveNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Gère l'apparition des ennemis en demandant un pattern a EnnemisPattern.
    /// Après un certain nombre de vagues on fait apparaître le boss
    /// </summary>
    /// <returns></returns>
    private IEnumerator ennemySpawn()
    {
        while (m_waveNumber < m_wavesBeforeBoss)
        {
            int numEnnemiesSpawned = 0;
            yield return new WaitForSeconds(m_WaveDelay);
            while(numEnnemiesSpawned < m_EnnemyPerWave)
            {
                //Chaque ennemi de la vague peut avoir un pattern différent
                yield return new WaitForSeconds(m_spawnDelay);
                //z = 10
                List<Vector3> ennemiesPositions = EnnemiesPattern.getOnePattern();
                float timeEnnemyTravel = Random.Range(0.5f, 3.0f);
                foreach(Vector3 ennemyPos in ennemiesPositions)
                {
                    m_ennemy.transform.position = m_mainCamera.ScreenToWorldPoint(ennemyPos);
                    Ennemy e = Instantiate(m_ennemy).GetComponent<Ennemy>();
                    e.m_timeEnnemyTravel = timeEnnemyTravel;
                }
                numEnnemiesSpawned++;
                m_spawnDelay = Random.Range(0.5f, 1.0f);
            }
            m_waveNumber++;
        }

        //Apparition du boss au milieu en haut de l'écran
        m_boss.transform.position = m_mainCamera.ScreenToWorldPoint(new Vector3(Screen.width / 2, (float)(Screen.height + Screen.height * 0.25), 10.0f));
        Instantiate(m_boss);
    }
}
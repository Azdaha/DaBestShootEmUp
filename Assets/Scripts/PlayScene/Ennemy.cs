using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : Entity
{
    [Header("Ennemy statistics")]
    [SerializeField]
    float m_ennemySpeed;
    [SerializeField]
    float m_fireRate;

    [Header("GameObject references")]
    [SerializeField]
    GameObject m_ennemyBullet;
    [SerializeField]
    GameObject m_dropHealth;
    [SerializeField]
    GameObject m_dropAS;

    private Camera m_mainCamera;

    [HideInInspector]
    public float m_timeEnnemyTravel; //Temps avant que l'ennemi ne démarre son mouvement latéral

    private float m_LeftDiagonalSpeed; //Vitesse de déplacement latérale

    // Start is called before the first frame update
    void Start()
    {
        m_mainCamera = Camera.main;
        m_LeftDiagonalSpeed = 0.0f;
        StartCoroutine(fire());
        StartCoroutine(travelDiagonnaly());
    }

    // Update is called once per frame
    void Update()
    {
        ennemyMovement();
    }

    /// <summary>
    /// Gère le mouvement de l'ennemi et le détruit s'il va en dehors de l'écran
    /// </summary>
    private void ennemyMovement()
    {
        this.transform.Translate(m_LeftDiagonalSpeed * Time.deltaTime, -m_ennemySpeed * Time.deltaTime, 0.0f);
        if((m_mainCamera.WorldToScreenPoint(this.transform.position).y) < 0.0f - Screen.height * 0.1)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player":
                Destroy(this.gameObject);
                break;
            case "Bullet":
                m_HP--;
                if (m_HP < 1)
                {
                    //5% de chance de droper un bonus
                    float randomDrop = Random.Range(0.0f, 1.0f);
                    if(randomDrop < 0.05f)
                    {
                        // 50% pour chaque bonus
                        int drop = Random.Range(0, 2);
                        if(drop == 0)
                        {
                            m_dropHealth.transform.position = this.transform.position;
                            Instantiate(m_dropHealth);
                        }
                        else
                        {
                            m_dropAS.transform.position = this.transform.position;
                            Instantiate(m_dropAS);
                        }
                    }
                    Destroy(this.gameObject);
                }
                    
                break;
        }
    }

    /// <summary>
    /// Gère le feu automatique des ennemis
    /// </summary>
    /// <returns></returns>
    private IEnumerator fire()
    {
        yield return new WaitForSeconds(0.75f);
        m_ennemyBullet.transform.position = this.gameObject.transform.position;
        Instantiate(m_ennemyBullet);
        while (this.isActiveAndEnabled)
        {
            yield return new WaitForSeconds(m_fireRate);
            m_ennemyBullet.transform.position = this.gameObject.transform.position;
            Instantiate(m_ennemyBullet);
        }
    }

    /// <summary>
    /// Permet de faire bouger latéralement l'ennemi selon sa position par rapport au centre
    /// (S'il est plus a gauche du centre, il ira à droite et vice-versa)
    /// </summary>
    /// <returns></returns>
    private IEnumerator travelDiagonnaly()
    {
        yield return new WaitForSeconds(m_timeEnnemyTravel);
        if(m_mainCamera.WorldToScreenPoint(this.transform.position).x >= Screen.width / 2)
        {
            m_LeftDiagonalSpeed = -2.0f;
        }
        else
        {
            m_LeftDiagonalSpeed = 2.0f;
        }
    }
}

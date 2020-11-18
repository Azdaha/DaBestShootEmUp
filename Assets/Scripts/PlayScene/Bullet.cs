using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Bullet statistic")]
    [SerializeField]
    private float m_bulletSpeed;

    private Camera m_mainCamera;

    public event Action onHit = null;//Évènement qui envoie le score à l'interface utilisateur
 
    // Start is called before the first frame update
    void Start()
    {
        m_mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        bulletMovement();
    }

    //Gère le mouvement de la balle et la détruit si elle va trop haut
    private void bulletMovement()
    {
        this.transform.Translate(0.0f, m_bulletSpeed * Time.deltaTime, 0.0f);

        if(m_mainCamera.WorldToScreenPoint(this.transform.position).y > Screen.height + Screen.height * 0.1)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ennemy"))
        {
            onHit?.Invoke();
            Destroy(gameObject);
        }
    }
}
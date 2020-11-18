using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyBullet : MonoBehaviour
{
    [Header("Bullet statistic")]
    [SerializeField]
    private float m_bulletSpeed;

    private Camera m_mainCamera;

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

    /// <summary>
    /// Gère le mouvement de la balle et la détruit si elle va en dehors de l'écran
    /// </summary>
    private void bulletMovement()
    {
        this.transform.Translate(0.0f, -m_bulletSpeed * Time.deltaTime, 0.0f);

        if (m_mainCamera.WorldToScreenPoint(this.transform.position).y < -Screen.height * 0.1)
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
        }
    }

}

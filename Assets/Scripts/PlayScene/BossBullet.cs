using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    [Header("Bullet Statistic")]
    [SerializeField]
    private float m_bulletSpeed;

    private Camera m_mainCamera;
    private float m_heightOffset;
    private float m_widthOffset;

    // Start is called before the first frame update
    void Start()
    {
        m_heightOffset = Screen.height * 0.1f;
        m_widthOffset = Screen.width * 0.05f;
        m_mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        bulletMovement();
    }

    /// <summary>
    /// Gère le movement de la balle et la détruit si elle va trop à gauche, à droite ou en bas de l'écran
    /// </summary>
    private void bulletMovement()
    {
        //Elle avance tout droit en fonction de son orientation de l'axe Z
        this.transform.Translate(m_bulletSpeed * Time.deltaTime, 0.0f, 0.0f);

        
        if ((m_mainCamera.WorldToScreenPoint(this.transform.position).y) < -10.0f - m_heightOffset
            || (m_mainCamera.WorldToScreenPoint(this.transform.position).x) < -10.0f - m_widthOffset
            || (m_mainCamera.WorldToScreenPoint(this.transform.position).x) > Screen.width + 10.0f + m_widthOffset)
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

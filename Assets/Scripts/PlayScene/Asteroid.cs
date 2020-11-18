using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [Header("Asteroid parameters")]
    [SerializeField]
    float m_speed;
    [SerializeField]
    public int m_directionOrigin;

    private Camera m_mainCam;

    

    private float m_randomDirection;
    private float m_randomXRotate, m_randomYRotate, m_randomZRotate;

    // Start is called before the first frame update
    void Start()
    {
        m_mainCam = Camera.main;
        m_randomDirection = Random.Range(-5.0f, 5.0f);
        m_randomXRotate = Random.Range(-3.0f, 3.0f);
        m_randomYRotate = Random.Range(-3.0f, 3.0f);
        m_randomZRotate = Random.Range(-3.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        asteroidMove();
    }

    /// <summary>
    /// Gère le déplacement des astéroïdes selon une direction et roation aléatoire.
    /// Les astéroïdes sont détruit s'ils vont trop loin en dehors de l'écran
    /// </summary>
    private void asteroidMove()
    {
        switch (m_directionOrigin)
        {
            //Déplacement dans le référentiel World pour éviter tout problème avec la rotation
            case 0://Coming from upward
                this.transform.Translate(m_randomDirection * Time.deltaTime, -m_speed * Time.deltaTime, 0.0f, Space.World);
                this.transform.Rotate(new Vector3(m_randomXRotate, m_randomYRotate, m_randomZRotate));
                break;
            case 1://Coming from downward
                this.transform.Translate(m_randomDirection * Time.deltaTime, m_speed * Time.deltaTime, 0.0f, Space.World);
                this.transform.Rotate(new Vector3(m_randomXRotate, m_randomYRotate, m_randomZRotate));
                break;
            case 2://Coming from left
                this.transform.Translate(m_speed * Time.deltaTime, m_randomDirection * Time.deltaTime, 0.0f, Space.World);
                this.transform.Rotate(new Vector3(m_randomXRotate, m_randomYRotate, m_randomZRotate));
                break;
            case 3://Coming from right
                this.transform.Translate(-m_speed * Time.deltaTime, m_randomDirection * Time.deltaTime, 0.0f, Space.World);
                this.transform.Rotate(new Vector3(m_randomXRotate, m_randomYRotate, m_randomZRotate));
                break;
                
        }

        double widthOffset = Screen.width * 0.05;
        double heightOffset = Screen.height * 0.1;

        if((m_mainCam.WorldToScreenPoint(this.transform.position).y) < -10.0f - heightOffset
            || (m_mainCam.WorldToScreenPoint(this.transform.position).y) > Screen.height + 10.0f + heightOffset
            || (m_mainCam.WorldToScreenPoint(this.transform.position).x) < -10.0f - widthOffset
            || (m_mainCam.WorldToScreenPoint(this.transform.position).x) > Screen.width + 10.0f + widthOffset)
        {
            Destroy(this.gameObject);
        }
    }
}

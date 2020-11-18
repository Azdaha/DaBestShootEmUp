using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Player : Entity
{
    [Header("Camera Settings")]
    [SerializeField]
    private Camera m_mainCamera;

    [Header("Player statistics")]
    [SerializeField]
    private float m_verticalSpeed;
    [SerializeField]
    private float m_horizontalSpeed;
    [SerializeField]
    private float m_reloadTime;

    [Header("Bullet Prefab")]
    [SerializeField]
    private GameObject m_bullet;

    private Stopwatch m_cooldown;
    private int m_score;

    private bool m_hittable;

    public event Action<int> onScoreChangeEvent = null;
    public event Action<int> onHPChangeEvent = null;
    public event Action onASChangeEvent = null;

    private void Awake()
    {
        m_HP = 5;
        m_cooldown = new Stopwatch();
        m_cooldown.Start();
        m_hittable = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        m_score = 0;
    }

  
    // Update is called once per frame
    void Update()
    {
        PlayerControl();
    }

    /// <summary>
    /// Gère les collisions, envoie la vie à l'interface utilisateur et rend invincible un court moment si besoin est
    /// </summary>
    /// <param name="collision">L'objet avec lequel le joueur est rentré en collision</param>
    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.CompareTag("Ennemy") || collision.gameObject.CompareTag("EnnemyBullet")) && m_hittable)
        {
            m_HP--;
            onHPChangeEvent.Invoke(m_HP);
            if (m_HP < 1)
            {
                Destroy(this.gameObject);
            }
            StartCoroutine(invicibilityAfterHit());
        }else if (collision.gameObject.CompareTag("BonusHealth"))
        {
            if (m_HP < m_maxHP)
            {
                m_HP++;
                onHPChangeEvent.Invoke(m_HP);
            }
        }
        else if (collision.gameObject.CompareTag("BonusAS"))
        {
            if (m_reloadTime > 10.0f)
            {
                m_reloadTime -= 10.0f;
                onASChangeEvent.Invoke();
            }
        }
    }

    /// <summary>
    /// Permet d'envoyer le score à l'interface utilisateur
    /// </summary>
    private void onBulletHit()
    {
        m_score += 100;
        onScoreChangeEvent.Invoke(m_score);
    }

    /// <summary>
    /// Permet de gérer les mouvements ainsi que l'arme du joueur
    /// </summary>
    private void PlayerControl()
    {
        Vector3 positionScreen = m_mainCamera.WorldToScreenPoint(this.transform.position);
        //Les offsets sont la pour que le joueur ne sorte pas à moitié de l'écran
        double widthOffset = Screen.width * 0.05;
        double heightOffset = Screen.height * 0.1;

        if (Input.GetKey(KeyCode.LeftArrow) && positionScreen.x > widthOffset)
        {
            this.transform.Translate(-m_horizontalSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
        

        if (Input.GetKey(KeyCode.RightArrow) && positionScreen.x < Screen.width - widthOffset)
        {
            this.transform.Translate(m_horizontalSpeed * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.UpArrow) && positionScreen.y < Screen.height - heightOffset)
        {
            this.transform.Translate(0.0f, 0.0f, m_verticalSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) && positionScreen.y > heightOffset)
        {
            this.transform.Translate(0.0f, 0.0f, -m_horizontalSpeed * Time.deltaTime);
        }

        //On joue le son de tir, redémarre le chronomètre pour le tir et on abonne la balle pour s'en servir pour le score
        if (Input.GetKey(KeyCode.Space) && m_cooldown.ElapsedMilliseconds > m_reloadTime && GameManager.Instance.Pause)
        {
            GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
            m_cooldown.Restart();
            m_bullet.transform.position = this.gameObject.transform.position;
            Bullet bullet = Instantiate(m_bullet).GetComponent<Bullet>();
            bullet.onHit += onBulletHit;
        }

    }

    private void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent("P")))
        {
            if (GameManager.Instance.Pause)
            {
                GameManager.Instance.Play(true);
            }
            else
            {
                GameManager.Instance.Play(false);
            }
        }
    }

    public int getScore()
    {
        return m_score;
    }

    /// <summary>
    /// Rend le joueur invincible pendant 1.5 secondes après avoir subi des dégâts
    /// </summary>
    /// <returns></returns>
    private IEnumerator invicibilityAfterHit()
    {
        BoxCollider collider = GetComponent<BoxCollider>();
        m_hittable = false;
        yield return new WaitForSeconds(1.5f);
        m_hittable = true;
    }
}

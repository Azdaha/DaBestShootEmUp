using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Entity
{
    [Header("GameObject reference")]
    [SerializeField]
    GameObject m_bullet;

    private float m_delayBetweenAttacks;
    private bool m_hasArrived;

    // Start is called before the first frame update
    private void Awake()
    {
        m_HP = 200;
    }
    void Start()
    {
        m_delayBetweenAttacks = 2.0f;
        m_hasArrived = false;
        StartCoroutine(attack());
    }

    // Update is called once per frame
    void Update()
    {
        if (!m_hasArrived)
        {
            //On le fait descendre tout qu'il n'est pas arrivé en haut de l'écran où il restera pour le combat
            this.transform.Translate(new Vector3(0.0f, -1.0f * Time.deltaTime, 0.0f));
            if (Camera.main.WorldToScreenPoint(this.transform.position).y < Screen.height) m_hasArrived = true; ;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Bullet":
                m_HP--;
                if (m_HP < 1)
                {
                    UserInterface.bossDefeat();//On signale la défait du boss pour terminer la partie
                    Destroy(this.gameObject);
                }

                break;
        }
    }

    /// <summary>
    /// Permet de créer les différentes attaques du boss et de la exécuter en demandant un pattern à BossBulletPatterns
    /// </summary>
    /// <returns></returns>
    private IEnumerator attack()
    {
        while (this.isActiveAndEnabled)
        {
            yield return new WaitForSeconds(m_delayBetweenAttacks);
            List<Vector4> bulletPositionsRotation = BossBulletPatterns.getOneBulletPattern();
            foreach(Vector4 bulletPosAndRot in bulletPositionsRotation)
            {
                m_bullet.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(bulletPosAndRot.x, bulletPosAndRot.y, bulletPosAndRot.z));
                //On récupère l'instance de la balle pour faire une rotation sur l'axe Z de la balle et non du préfab
                BossBullet bossBullet = Instantiate(m_bullet).GetComponent<BossBullet>();
                bossBullet.transform.Rotate(0.0f, 0.0f, bulletPosAndRot.w);
            }
        }
    }
}

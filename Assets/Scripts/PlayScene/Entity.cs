using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe pour les différentes entités qui composents le jeu et qui vont se battre (Joueur, Ennemy et Boss)
/// </summary>
public class Entity : MonoBehaviour
{
    [Header("Health Statistic")]
    [SerializeField]
    public int m_maxHP;

    protected int m_HP;

    virtual protected void Awake()
    {
        m_HP = m_maxHP;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getHP() { return m_HP; }
}

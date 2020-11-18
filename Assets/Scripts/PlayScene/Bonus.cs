using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe qui sert de base pour les bonus
/// </summary>
public class Bonus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Gère le mouvement des bonus qui descendent et tournent. Ils sont détruit s'il arrivent trop bas hors de l'écran
    /// </summary>
    protected void bonusMovement()
    {
        this.transform.Translate(new Vector3(0.0f, -3.0f * Time.deltaTime, 0.0f), Space.World);
        this.transform.Rotate(new Vector3(0.0f, 100.0f * Time.deltaTime, 0.0f));
        if ((Camera.main.WorldToScreenPoint(this.transform.position).y) < 0.0f - Screen.height * 0.1)
        {
            Destroy(this.gameObject);
        }
    }

    /// <summary>
    /// Permet de gérer les collisions spécifique pour chaque bonus
    /// </summary>
    /// <param name="collision">L'objet de la collision</param>
    virtual protected void OnCollisionEnter(Collision collision) { }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusHealth : Bonus
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bonusMovement();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) 
        {
            --collision.gameObject.GetComponent<EnemyLifes>().vidas; 
        }

        Destroy(gameObject);
    }
}

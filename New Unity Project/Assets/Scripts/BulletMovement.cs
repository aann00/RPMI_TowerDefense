using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletspeed;
    public GameObject enemy;

    

    // Update is called once per frame
    void Update()
    {
        if(enemy != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, enemy.transform.position, bulletspeed);
        }
        else
        {
            Destroy(gameObject);
        }
       
    }

    
}

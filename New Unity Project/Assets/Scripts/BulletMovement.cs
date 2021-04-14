using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletspeed;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);  
    }

    // Update is called once per frame
    void Update()
    {
        Vector3.MoveTowards(transform.position, enemy.transform.position, bulletspeed);
        //transform.Translate(0, bulletspeed, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}

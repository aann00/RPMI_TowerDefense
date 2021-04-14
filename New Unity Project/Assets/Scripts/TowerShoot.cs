using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject enemy;
    public float height;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bala = Instantiate(bulletPrefab, transform.position + new Vector3(0, height, 0), Quaternion.identity);
            bala.GetComponent<BulletMovement>().enemy = enemy;
        } 




    }
}

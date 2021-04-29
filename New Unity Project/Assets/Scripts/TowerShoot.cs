using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject enemy;
    public float height;
    public float shootFrecuency;
    private float lastShootTime;


    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (enemy != null) 
        {
            if (Time.time - lastShootTime >= shootFrecuency)
            {
                //Realiza el disparo
                GameObject bala = Instantiate(bulletPrefab, transform.position + new Vector3(0, height, 0), Quaternion.identity);
                //Asigna la bala instanciada al enemigo
                bala.GetComponent<BulletMovement>().enemy = enemy;
                //Registra el momento en que se ha disparado
                lastShootTime = Time.time;
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy")) 
        {
            enemy = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        enemy = null;
    }
}

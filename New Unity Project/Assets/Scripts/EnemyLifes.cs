using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLifes : MonoBehaviour
{
    public int vidas;
    public Healthbar healthbar;


    // Update is called once per frame
    void Update()
    {
        if(vidas <= 0)
        {
            Destroy(gameObject);
        }
    }

    
}

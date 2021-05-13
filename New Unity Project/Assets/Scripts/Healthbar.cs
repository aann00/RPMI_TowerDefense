using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider slider;
    
    public void SetHealth(int vidas)
    {
        slider.value = vidas;
    }
    
    public void SetMaxHealth(int vidas)
    {
        slider.maxValue = vidas;
        slider.value = vidas;
    }
}

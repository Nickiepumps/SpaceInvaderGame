using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    public Slider hpSlider; // HP slider
    public void SetMaxHealth(int health) // Set hpSlider value to "health"
    {
        hpSlider.maxValue = health;
        hpSlider.value = health;
    }
    public void SetCurrentHealth(int health) // Set hpSlider value to current Player health
    {
        hpSlider.value = health;
    }
}

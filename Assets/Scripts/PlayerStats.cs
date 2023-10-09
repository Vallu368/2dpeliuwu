using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public float battlePower;
    public float energy;

    public float maxHealth;
    public float currentHealth;
    public GameObject healthBar;

    public TextMeshProUGUI bpNumber;
    public TextMeshProUGUI enNumber;

    public float str;
    public float spd;

    private void Awake()
    {
        currentHealth = maxHealth;
    }
    public void Update()
    {
        healthBar.GetComponent<Slider>().maxValue = maxHealth;
        healthBar.GetComponent<Slider>().value = currentHealth;

        if(currentHealth > maxHealth) // hp cant go over ma
        {
            currentHealth = maxHealth;
        }
        if (currentHealth < 0) //hp cant go over 0, possibly change in the future? 
        {
            currentHealth = 0;
        }

        bpNumber.text = battlePower.ToString();
        enNumber.text = energy.ToString();
    }

}

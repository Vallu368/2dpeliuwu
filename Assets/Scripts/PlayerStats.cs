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

    private void Awake()
    {
        currentHealth = maxHealth;
    }
    public void Update()
    {
        healthBar.GetComponent<Slider>().maxValue = maxHealth;
        healthBar.GetComponent<Slider>().value = currentHealth;

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }

        bpNumber.text = battlePower.ToString();
        enNumber.text = energy.ToString();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public float battlePower;
    public float energy;

    public TextMeshProUGUI bpNumber;
    public TextMeshProUGUI enNumber;

    public void Update()
    {
        bpNumber.text = battlePower.ToString();
        enNumber.text = energy.ToString();
    }

}

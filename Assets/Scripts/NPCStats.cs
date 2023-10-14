using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCStats : MonoBehaviour
{
    public Rigidbody2D rb;
    public float health = 10000000;
    public float defense = 100;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
           // this.gameObject.SetActive(false);
        }


    }

    public void TakeDamage(float damage)
    {
        float dmgTaken = damage / defense;
        health = health - dmgTaken;
        Debug.Log("took " + dmgTaken + " damage!");
    }
}

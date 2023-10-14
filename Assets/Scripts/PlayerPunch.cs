using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPunch : MonoBehaviour
{
    float destroyTime = 0.1f;
    public int energyDrain = 5;
    public PlayerAttack attack;
    public PlayerStats stats;

    private void Awake()
    {
        attack = GameObject.Find("Player").GetComponent<PlayerAttack>();
        stats = GameObject.Find("Player").GetComponent<PlayerStats>();


    }

    private void Update()
    {
        Destroy(gameObject, destroyTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Player")
        {
            Debug.Log(other.name);

            if(other.tag == "Humanoid")
            {
                if (other.GetComponent<NPCStats>() != null)
                {
                    other.GetComponent<NPCStats>().TakeDamage(attack.PunchDamage());
                    Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                    var direction = rb.transform.position - attack.gameObject.transform.position;

                    // Normalization is important, to have constant unit!
                    float pushForce = attack.PunchDamage();
                    pushForce = pushForce / other.GetComponent<NPCStats>().defense;
                    rb.AddForce(direction.normalized * pushForce, ForceMode2D.Force);
                }
            }
        }
    }
    
}

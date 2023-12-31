using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public PlayerStats stats;
    public GameObject attackUp;
    public GameObject attackDown;
    public GameObject attackLeft;
    public GameObject attackRight;

    public GameObject activeAttackDir;

    public GameObject punchGameObject;

    public int attackDrain = 5;

    private void Awake()
    {
        stats = GetComponent<PlayerStats>();
        playerMovement = GetComponent<PlayerMovement>();
        attackUp.SetActive(false);
        attackLeft.SetActive(false);
        attackRight.SetActive(false);

        activeAttackDir = attackDown;

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HandlePunchAttack();
        }
        HandleAttackDirection();
    }

    public void HandlePunchAttack()
    {
        if (stats.energy >= attackDrain) {
            stats.energy = stats.energy - attackDrain;
            Instantiate(punchGameObject, activeAttackDir.transform.position, activeAttackDir.transform.rotation);
        }
    }
    public float PunchDamage()
    {
        float punchDmg;
        punchDmg = stats.battlePower * stats.str;
        Debug.Log("Punchdamage is " + punchDmg);
        return punchDmg; //put raw dmg calcs here if using other than str
    }

    public void HandleAttackDirection()
    {
        if (playerMovement.lastDirection.x == 0 && playerMovement.lastDirection.y == 1)
        {
            attackUp.SetActive(true);
            attackDown.SetActive(false);
            attackLeft.SetActive(false);
            attackRight.SetActive(false);

            activeAttackDir = attackUp;
        }
        if (playerMovement.lastDirection.x == 0 && playerMovement.lastDirection.y == -1)
        {
            attackUp.SetActive(false);
            attackDown.SetActive(true);
            attackLeft.SetActive(false);
            attackRight.SetActive(false);

            activeAttackDir = attackDown;
        }
        else if (playerMovement.lastDirection.x == 0 && playerMovement.lastDirection.y == -1)
        {
            attackUp.SetActive(false);
            attackDown.SetActive(true);
            attackLeft.SetActive(false);
            attackRight.SetActive(false);

            activeAttackDir = attackDown;
        }
        else if (playerMovement.lastDirection.x == 1 && playerMovement.lastDirection.y == 0)
        {
            //movedir.x = 1, spawning attacks on right
            attackUp.SetActive(false);
            attackDown.SetActive(false);
            attackLeft.SetActive(false);
            attackRight.SetActive(true);

            activeAttackDir = attackRight;
        }
        else if (playerMovement.lastDirection.x == -1 && playerMovement.lastDirection.y == 0)
        {
            attackUp.SetActive(false);
            attackDown.SetActive(false);
            attackLeft.SetActive(true);
            attackRight.SetActive(false);

            activeAttackDir = attackLeft;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float timeToFix;
    public float startTimeToFix;
    

    public Transform AttackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int fix;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeToFix <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Collider2D[] houseFixing = Physics2D.OverlapCircleAll(AttackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i< houseFixing.Length; i++)
                {
                    houseFixing[i].GetComponent<House>().FixHouse(fix);
                }
            }
            timeToFix = startTimeToFix;
        }
        else
        {
            timeToFix -= Time.deltaTime;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(AttackPos.position, attackRange);
    }
}

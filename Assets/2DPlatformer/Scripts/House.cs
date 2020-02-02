using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public int health;

    void Update()
    {
        Die();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Damage taken");
    }

    public void FixHouse(int fix)
    {
        if (health < 10) {
            health += fix;
            Debug.Log("Fixing House");
        } else
        {
            Debug.Log("Already Fixed");
        }
    }

    void Die()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}

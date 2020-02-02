using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    private float timeToDamage;
    public float startTimeToDamage;
    private Animator animator;
    public int damage;

    // Start is called before the first frame update
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (timeToDamage <= 0)
        {
           GetComponent<House>().TakeDamage(damage);
           timeToDamage = startTimeToDamage;
           Debug.Log("House damaged.");
        }
        else
        {
            timeToDamage -= Time.deltaTime;
        }

    }
}

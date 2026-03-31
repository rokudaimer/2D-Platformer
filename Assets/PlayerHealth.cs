using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxhealth = 100;
    private float health;
    private bool canreceivedamage;
    public float invincibilityTimer = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void adddamage(float damage)
    { 
        health -= damage;
        Debug.Log(health);
    }
    public void AddHealth(float healthtoadd)
    {
        health += healthtoadd;
        Debug.Log(health); 
    }
}

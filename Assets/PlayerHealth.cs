using System;
using System.Collections;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxhealth = 100;
    private float health;
    private bool canreceivedamage = true;
    public float invincibilityTimer = 2;

    public delegate void HealthChangedHandler(float newHealth, float amountChanged);
    public event HealthChangedHandler OnHealthChanged;

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
        if (canreceivedamage)
        {
            health -= damage;
            OnHealthChanged?.Invoke(health, damage);
            canreceivedamage = false;
            StartCoroutine(InvincibilityTimer(invincibilityTimer, ResetInvincibility));
        }
        Debug.Log(health);
    }

    IEnumerator InvincibilityTimer(float time, Action callback)
    {
        yield return new WaitForSeconds(time);
        callback.Invoke(); 
    }

    private void ResetInvincibility()
    {
        canreceivedamage = true;
    }
    public void AddHealth(float healthtoadd)
    {
        health += healthtoadd;
        OnHealthChanged?.Invoke(health, healthtoadd);
        Debug.Log(health); 
    }
}

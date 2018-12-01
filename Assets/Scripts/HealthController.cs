using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour {
    public int currentHealth;
    public int maximumHealth = 1;

    void Start()
    {
        currentHealth = maximumHealth;
    }

    public void Damage(int amount)
    {
        //Negative damage doesn't exist
        if (amount <= 0)
        {
            return;
        }
        //Damage the unit
        currentHealth -= amount;
        //Do not go beyond zero
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            BroadcastMessage("Die");
        }
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        //Positive healing
        if (amount >= 0)
        {
            if (currentHealth > maximumHealth)
            {
                currentHealth = maximumHealth;
            }
        }
        //Negative healing: non-lethal!
        else
        {
            //Prevent lethal damage
            if (currentHealth <= 0)
            {
                currentHealth = 1;
            }
        }
    }
}

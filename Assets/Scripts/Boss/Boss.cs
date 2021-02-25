using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; 
        healthBar.SetMaxHealth(maxHealth);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetCurrentHealth() {
        return currentHealth;
    }

    public void TakeDamage (int damage)
    {
        StartCoroutine(HurtWaiter());
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    IEnumerator HurtWaiter()
    {
        GetComponent<BossAnimations>().Hurt();
        yield return new WaitForSecondsRealtime(0.2f);
        GetComponent<BossAnimations>().Idle();
        
    }
}

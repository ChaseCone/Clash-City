using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public int maxHealth = 3;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        Transform bar = transform.Find("Healthbar");
        HealthSystem hs = bar.GetComponent<HealthSystem>();
        hs.Setup(this);
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }

    public void Hit(int damage)
    {
        health -= damage;
        
    }

    public int GetHealth()
    {
        return health;
    }
    public float GetHealthPercent()
    {
        return (float)health / maxHealth;
    }
}

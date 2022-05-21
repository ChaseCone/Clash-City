using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public int maxHealth = 5;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        GameObject bar = GameObject.Find("HealthBar");
        //Debug.Log("Bar:" + bar);
        HealthSystem hs = bar.GetComponent<HealthSystem>();
        hs.Setup(this);

        GameObject bar1 = GameObject.Find("HealthBar1");
        //bar1.active = false;
        health = 1;
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

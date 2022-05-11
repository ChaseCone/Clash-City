using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthTest : MonoBehaviour
{
    public HealthSystem healthSystem;
    // Start is called before the first frame update
    void Start()
    {
        //HealthSystem.SetHealthBarValue(1);
        Health health = new Health(100);
        healthSystem.Setup(health);
    }

    // Update is called once per frame
    void Update()
    {
       // HealthSystem.SetHealthBarValue(HealthSystem.GetHealthBarValue() - 0.001f);
    }
}

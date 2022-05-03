using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        HealthSystem.SetHealthBarValue(1);
    }

    // Update is called once per frame
    void Update()
    {
        HealthSystem.SetHealthBarValue(HealthSystem.GetHealthBarValue() - 0.001f);
    }
}

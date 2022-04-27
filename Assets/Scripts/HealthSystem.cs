using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    private static Image HealthBarImage;
    
    public static void SetHealthBarColor(Color healthColor)
    {
        HealthBarImage.color = healthColor;
    }
    public static  void SetHealthBarValue(float value)
    {
        HealthBarImage.fillAmount = value;
        if (HealthBarImage.fillAmount < 0.2f)
        {
            SetHealthBarColor(Color.red);
        }
        else if (HealthBarImage.fillAmount < 0.5f)
        {
            SetHealthBarColor(Color.yellow);
        } else
        {
            SetHealthBarColor(Color.green);
        }
    }

    public static float GetHealthBarValue()
    {
        return HealthBarImage.fillAmount;
    }

    /*public void Heal(int healAmount)
    {
        health += healAmount;
    }*/

    // Start is called before the first frame update
    void Start()
    {
        HealthBarImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

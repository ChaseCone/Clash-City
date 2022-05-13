using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    private static Image HealthBarImage;
    private TowerManager health;

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
        else if (HealthBarImage.fillAmount < 0.55f)
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

    public void Setup (TowerManager health)
    {
        this.health = health;
    }

    // Update is called once per frame
    public void Update()
    {
        //GameObject bar = GameObject.Find("HealthBar");
        //Debug.Log("Health" + (health == null));
        //Debug.Log("Bar" + bar == null);

        // GameObject.Find("HealthBar").transform.localScale = new Vector3(health.GetHealthPercent(), 1);
        gameObject.transform.localScale = new Vector3(health.GetHealthPercent(), 1);
       // gameObject.transform.localScale = new Vector3(1,1,1);


    }
}

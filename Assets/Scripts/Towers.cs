using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towers : MonoBehaviour
{
    public GameObject ProjectilePrefab;
    public float fireRate =3f;
    public float Cooldown =2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Cooldown<=0f)
        {
            Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);
            Cooldown = 1f / fireRate;
            Cooldown = 3;
        }
        Cooldown -= Time.deltaTime;
    }

}

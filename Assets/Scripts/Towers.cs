using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towers : MonoBehaviour
{
    public GameObject ProjectilePrefab;
    public float fireRate = 3f;
    public float Cooldown = 2f;
    public bool isEnemy = false;
    public List<GameObject> targets = new List<GameObject>();
    public GameObject[] En;
    public int num = 0;
    public float radius;
    private Projectile p;
    public int dmg;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        En = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject e in En)
        {
            if (Vector3.Distance(e.transform.position, gameObject.transform.position) >= radius)
            {
                isEnemy = true;
               
                if (Cooldown <= 0f && isEnemy == true)
                {

                    GameObject g = Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);
                    targets.ToArray();
                    Cooldown = 1f / fireRate;
                    Cooldown = 3;
                    p = g.GetComponent<Projectile>();
                    p.enemy = e;
                    p.dmg = dmg;
                    isEnemy = false;

                }
                Cooldown -= Time.deltaTime;

            }

            else { isEnemy = false; }
        }

    
    }
}


  
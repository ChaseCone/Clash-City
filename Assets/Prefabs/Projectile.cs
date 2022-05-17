using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update

    private float speed = 55.0f;
    Vector3 lookPostion;
    public GameObject enemy;
    public Towers towerScript;
    public EnemyMove foe;
    public int dmg = 1;
    void Start()
    {
       
    }

    // Update is called once per frame
    void LateUpdate()
    {
     
        
            lookPostion = (enemy.transform.position - transform.position).normalized;
            transform.Translate(lookPostion * Time.deltaTime * speed);
       
    }

    public void OnTriggerEnter(Collider other)
    {
        if (enemy == other.gameObject)
        {
          
            Destroy(gameObject);
            foe.health -= dmg;
            
           
        }

    }


}

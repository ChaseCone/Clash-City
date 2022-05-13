using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update

    private float speed = 55.0f;
    Vector3 lookPostion;
    private GameObject enemy;
    private Towers towerScript;
    void Start()
    {
        towerScript = GameObject.Find("AOE").GetComponent<Towers>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy = towerScript.setEnemy;
        if (towerScript.isEnemy && towerScript.setEnemy != null)
        {
            lookPostion = (enemy.transform.position - transform.position).normalized;
            transform.Translate(lookPostion * Time.deltaTime * speed);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (enemy == other.gameObject)
        {
            Destroy(enemy);
            Destroy(gameObject);
            towerScript.isEnemy = false;
            towerScript.setEnemy = null;
        }

    }


}

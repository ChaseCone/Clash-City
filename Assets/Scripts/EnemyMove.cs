using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 50;
    public int maxHealth = 3;
    public int health;
    public int coinsOnKill = 10;
    private GameObject currTarget = null;
    private float destination;
    private float hitTimer = 0;
    public  int hitCoolDown = 2;
    public GameObject currencyManager;
    private CurrencyManager manager;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        currencyManager = GameObject.Find("CurrencyManager");
        manager = currencyManager.GetComponent<CurrencyManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToTower = float.MaxValue;
        GameObject nearestTower = null;
        GameObject[] allTowers = GameObject.FindGameObjectsWithTag("Tower");

        foreach (GameObject currTower in allTowers)
        {
            if(Vector3.Distance(gameObject.transform.position, currTower.transform.position) < distanceToTower)
            {
                nearestTower = currTower;
                distanceToTower = Vector3.Distance(gameObject.transform.position, currTower.transform.position);
                if(currTower != currTarget)
                {
                    currTarget = currTower;
                    destination = Random.Range(-40, 40);
                }
            }
        }

        if (nearestTower != null)
        {
            transform.LookAt(nearestTower.transform);
            Debug.DrawLine(gameObject.transform.position, nearestTower.transform.position, Color.red);
            Vector3 move = new Vector3(nearestTower.transform.position.x - transform.position.x + destination, nearestTower.transform.position.y - transform.position.y, nearestTower.transform.position.z - transform.position.z + 35);
            transform.Translate(move.normalized * speed * Time.deltaTime, Space.World);

            hitTimer += Time.deltaTime;
            if (move.x <= 1 && move.y <= 1 && move.z <= 1 && hitTimer >= hitCoolDown)
            {
                nearestTower.GetComponent<TowerManager>().Hit(1);
                hitTimer = 0;
            }
        }

        if (health == 0)
        {
            Destroy(gameObject);
        
        }

    }

    private void OnDestroy()
    {
        manager.addCurrency(coinsOnKill);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private float speed = 50;
    private GameObject currTarget = null;
    private float destination;
    // Start is called before the first frame update
    void Start()
    {
        
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
                distanceToTower = Vector3.Distance(gameObject.transform.position, currTower.transform.position);
                nearestTower = currTower;
                if(currTower != currTarget)
                {
                    currTarget = currTower;
                    destination = Random.Range(nearestTower.transform.position.x - 40, nearestTower.transform.position.x + 40);
                }
            }
        }

        transform.LookAt(nearestTower.transform);
        Debug.DrawLine(gameObject.transform.position, nearestTower.transform.position, Color.red);
        transform.Translate((nearestTower.transform.position - transform.position + new Vector3(destination, 0, 35)).normalized * speed * Time.deltaTime, Space.World);

    }
}

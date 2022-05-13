using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towers : MonoBehaviour
{
    public GameObject ProjectilePrefab;
    public float fireRate = 3f;
    public float Cooldown = 2f;
    public GameObject setEnemy;
    public bool isEnemy = false;
    private List<GameObject> targets = new List<GameObject>();
    public GameObject[] En;
    public int num;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Cooldown <= 0f && isEnemy == true)
        {

            Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);

            Cooldown = 1f / fireRate;
            Cooldown = 3;
            En = targets.ToArray();
            setEnemy = En[0];
            if (En.Length > 1 && En[num] == null)
            {
                num++;
                setEnemy = En[num];
            }

        }
        Cooldown -= Time.deltaTime;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {

            Debug.Log("Yes");
            targets.Add(other.gameObject);
            isEnemy = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (targets.Contains(other.gameObject))
        {
            targets.Remove(other.gameObject);
        }
    }

}


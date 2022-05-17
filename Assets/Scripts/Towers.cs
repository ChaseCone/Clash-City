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
    public int num = 0;
    public float radius = 50;
    private Projectile p;
   

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
            if (Vector3.Distance(gameObject.transform.position, e.transform.position) <= radius)
            {
                isEnemy = true;
                if (Cooldown <= 0f && isEnemy == true)
                {

                    GameObject g = Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);

                    Cooldown = 1f / fireRate;
                    Cooldown = 3;
                    p = g.GetComponent<Projectile>();
                    p.enemy = En[0];
                    

                }
                Cooldown -= Time.deltaTime;

            }
        }



    }
}


   //private void OnTriggerEnter(Collider other)
   //{
   //  if (other.CompareTag("Enemy"))
   //   {

//   Debug.Log("Yes");
//      targets.Add(other.gameObject);
//      isEnemy = true;

//    }
// }*
// private void OnTriggerExit(Collider other)
// {
//     if (targets.Contains(other.gameObject))
//     {
//    targets.Remove(other.gameObject);
//    }
// }

//}


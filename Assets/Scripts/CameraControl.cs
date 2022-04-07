using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject Zoomer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * 50 * horizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * 50 * verticalInput);
        if (transform.position.x < -390)
        {
            transform.position = new Vector3(-389, transform.position.y, transform.position.z);
        }

        if (transform.position.y > 810)
        {
            transform.position = new Vector3(transform.position.x, 809, 525);
        }

        if (transform.position.y < 665)
        {
            transform.position = new Vector3(transform.position.x, 666, 910);
        }

        if (transform.position.x > 390)
        {
            transform.position = new Vector3(389, transform.position.y, transform.position.z);
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0 && Zoomer.GetComponent<Camera>().fieldOfView < 45.3)
        {
            Zoomer.GetComponent<Camera>().fieldOfView++;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            Zoomer.GetComponent<Camera>().fieldOfView--;
        }

    }
}

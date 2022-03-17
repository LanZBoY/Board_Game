using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnter : MonoBehaviour
{

    public GameObject cube;
    public bool active = false;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(active);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit");
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Player")
        {
            Debug.Log("Triggered by Player");
            Color color = Color.red;
            cube.GetComponent<MeshRenderer>().material.color = color;
            //GetComponent<Light>().enabled = true;
            if(active == false)
            {
                active = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Color color = Color.grey;
        cube.GetComponent<MeshRenderer>().material.color = color;
        if (active == true)
        {
            active = false;
        }
    }
}

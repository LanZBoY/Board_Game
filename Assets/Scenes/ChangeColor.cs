using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public BoxCollider up;
    public BoxCollider down;
    public BoxCollider left;
    public BoxCollider right;

    // Start is called before the first frame update
    SpriteRenderer sr;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        sr.color = new Color(2, 0, 0);
    }
}

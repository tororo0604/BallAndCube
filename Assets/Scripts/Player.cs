using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jump_speed;
    public bool is_landing;

    // Start is called before the first frame update
    void Start()
    {
        this.is_landing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.is_landing)
        {
            if (Input.GetMouseButtonDown(0))
            {
                this.is_landing = false;
                this.GetComponent<Rigidbody>().velocity = Vector3.up * this.jump_speed;
            }
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        this.is_landing = true;
    }
}

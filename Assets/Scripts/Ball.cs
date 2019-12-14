using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float loanchSpeedX;
    public float loanchSpeedY;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().velocity
         = new Vector3(-loanchSpeedX, loanchSpeedY, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}

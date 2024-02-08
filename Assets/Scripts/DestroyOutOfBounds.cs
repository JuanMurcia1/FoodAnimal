using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float Range=30.0f;
    private float Range2= -17.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > Range ){
            Destroy(gameObject);
        }else if (transform.position.z < Range2 ){

            Destroy(gameObject);
        }
    }
}

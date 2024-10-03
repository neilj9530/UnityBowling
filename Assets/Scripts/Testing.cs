using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetMouseButton(0));
        //Movement
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, -2 * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(2 * Time.deltaTime, 0,0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, 2 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-2 * Time.deltaTime, 0, 0);
        }

        //debug checker
        if (Time.realtimeSinceStartup > 5 && 3 > 0)
        {
            Debug.Log("This condition is true");        
        }

        //rotation
        transform.Rotate(0, 0, 180 * Time.deltaTime);
    }
}

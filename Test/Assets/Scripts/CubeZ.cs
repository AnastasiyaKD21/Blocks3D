using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeZ : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;

    private void FixedUpdate()
    {
        if(Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }

        if(Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
    }
}

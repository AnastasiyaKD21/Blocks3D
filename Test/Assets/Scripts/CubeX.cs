using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeX : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;

    private void FixedUpdate()
    {
        if(Input.GetKey("s"))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }

        if(Input.GetKey("w"))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
    }
}

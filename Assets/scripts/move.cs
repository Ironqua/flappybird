    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float h�z;

    private void Start()
    {
        Destroy(gameObject,7);
    }


    void FixedUpdate()
    {
        transform.position += Vector3.left * h�z * Time.deltaTime;
    }
}

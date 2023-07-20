    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float hýz;

    private void Start()
    {
        Destroy(gameObject,7);
    }


    void FixedUpdate()
    {
        transform.position += Vector3.left * hýz * Time.deltaTime;
    }
}

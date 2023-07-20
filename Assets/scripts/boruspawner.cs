using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boruspawner : MonoBehaviour
{
    // Start is called before the first frame update
    public kuþ BirdScript;
    public GameObject borular;
    public float time;
    void Start()
    {
        StartCoroutine(spawnobject(time ));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator spawnobject(float time)
    {
        while (!BirdScript.isDead)
        {
            Instantiate(borular, new Vector3(1.5F,  Random.Range(0.02f, 0.7f),0) , Quaternion.identity);
            yield return new WaitForSeconds( time);
        }

        
    }
}

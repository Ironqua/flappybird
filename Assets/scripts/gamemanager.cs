using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public Text scoretext;
    void Start()
    {
        score = 0;
        scoretext.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updatescore()
    {
        score++;
        scoretext.text = score.ToString();
    }

   
   public int skoroyunsonu()
    {
        return score;
    }
}

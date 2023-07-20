using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class butonscript : MonoBehaviour
{
    public void digersahne()
    {
        SceneManager.LoadScene("flappybird");


    }

    public void quitgame()
    {
        Debug.Log("çýkýþ");
        Application.Quit();
    }



}


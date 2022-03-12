using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nxtLevel2 : MonoBehaviour
{

    void Update()
    {
        if(bullet.score >= 3000)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}

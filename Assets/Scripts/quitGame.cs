using UnityEngine;

public class quitGame : MonoBehaviour
{
    void Start()
    {
        Invoke("QuitGame", 4f);
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
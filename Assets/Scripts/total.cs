using UnityEngine;
using UnityEngine.UI;

public class total : MonoBehaviour
{
    Text totalScore;

    void Start()
    {
        totalScore = GameObject.Find("total").GetComponent<Text>();
        totalScore.text = bullet.score.ToString();
        Invoke("quitGame", 3f);
    }

    void quitGame()
    {
        Application.Quit();
    }
}

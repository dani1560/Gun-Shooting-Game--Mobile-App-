using UnityEngine;

public class Instantiate2 : MonoBehaviour
{
    public GameObject enemy;

    void Start()
    {
        InvokeRepeating("goEnemy", 2f, 2f);
        
    }

    void goEnemy()
    {
         Instantiate(enemy, transform.position, transform.rotation);
        
    }
}

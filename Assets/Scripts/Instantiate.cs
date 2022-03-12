using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject enemy;
    public Material[] material;
    Renderer rend;

    void Start()
    {
        InvokeRepeating("goEnemy", 2f, 2f);
        rend = enemy.GetComponent<Renderer>();
    }

    void goEnemy()
    {
         Instantiate(enemy, transform.position, transform.rotation);
        rend.material = material[Random.Range(0, material.Length)];
    }
}

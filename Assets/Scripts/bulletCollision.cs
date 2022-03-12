using UnityEngine;

public class bulletCollision : MonoBehaviour
{
    string name;
    public Material[] material2;

    private void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        name = collision.gameObject.GetComponent<Renderer>().material.name;
        name = name.Substring(0, 5);

        //-------------
        if (collision.gameObject.name == "Cube (1)" || collision.gameObject.name == "Cube (2)" || 
            collision.gameObject.name == "Cube (3)" || collision.gameObject.name == "Cube (4)" ||
            collision.gameObject.name == "Cube" || collision.gameObject.name == "Plane" ||
            collision.gameObject.name == "Cube (5)" || collision.gameObject.name == "Cube (6)"
            )
        {
            Debug.Log("cameraaa hitssss");
        }
        else
        {
            
            if (name == "Fire1")
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
                bullet.score += 10;

                Debug.Log("Fire 1");
            }
            else if (name == "Fire2")
            {
                bullet.life1 ++;
                
                if(bullet.life1 == 2)
                {
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                    bullet.score += 20;
                    Debug.Log("Fire 2");
                    bullet.life1 = 0;
                }
           

            }
            else if (name == "Fire3")
            {
                bullet.life2 ++;

                if (bullet.life2 == 3)
                {
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                    bullet.score += 30;
                    Debug.Log("Fire 3");
                    bullet.life2 = 0;
                }
            }
            else
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
                bullet.score ++;
                Debug.Log("only Fire");
            }

            
        }
        
    }

}

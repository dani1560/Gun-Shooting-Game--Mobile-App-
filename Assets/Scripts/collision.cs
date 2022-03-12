using UnityEngine;

public class collision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        Destroy(collision.gameObject);
        
    }
}

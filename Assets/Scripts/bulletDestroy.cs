using UnityEngine;

public class bulletDestroy : MonoBehaviour
{
    void Update()
    {
        if(gameObject.transform.position.z == 10f)
        {
            Destroy(gameObject);
        }
    }
}

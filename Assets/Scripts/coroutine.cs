using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutine : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    float distance;

    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(coroutineFunction());

        Debug.Log("Main Function");
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(cube1.transform.position, cube2.transform.position);
        Debug.Log(distance);
    }

    IEnumerator coroutineFunction()
    {
        Debug.Log("coroutine Function calling A");

        yield return new WaitForSeconds(5);

        Debug.Log("coroutine Function calling B");
    }
}

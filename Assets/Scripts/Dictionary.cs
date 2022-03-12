using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    // Start is called before the first frame update

    Dictionary<int, string> countries = new Dictionary<int, string>();
    void Start()
    {
        countries.Add(1, "Pakistan");
        countries.Add(2, "India");
        countries.Add(3, "Australia");
        countries.Add(4, "Newzealand");
        countries.Add(5, "Africa");

        Debug.Log(countries[1]);

        /*foreach (var getCountries in countries) {

            Debug.Log(getCountries.Key + " : " + getCountries.Value);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

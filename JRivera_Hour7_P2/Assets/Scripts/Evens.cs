using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int even = 22; even <= 100; even = even+2)
        {
            Debug.Log (even);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

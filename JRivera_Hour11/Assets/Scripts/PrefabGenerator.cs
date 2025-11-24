using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public int numberOfPrefabs = 10;
    public float spawnOffset = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfPrefabs; i++)
        {
            Vector3 spawnPosition = new Vector3(i * spawnOffset, 0, 0);
            Instantiate (prefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

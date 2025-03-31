using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject myObject;
    public int spawnNum;
    public float yLevel;

    private int start = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start < spawnNum) {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-100, 100), yLevel, Random.Range(-100, 100));

            Instantiate(myObject, randomSpawnPosition, Quaternion.identity);

            start += 1;
        }
    }
}

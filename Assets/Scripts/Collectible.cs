using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public AudioSource collectSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1f, 0, Space.World);
    }

    void OnTriggerEnter(Collider other) {
        collectSound.Play();
        PlayerCharacter.currentGems += 1;
		Destroy(gameObject);
	}
}

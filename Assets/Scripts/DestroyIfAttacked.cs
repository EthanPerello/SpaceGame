using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIfAttacked : MonoBehaviour
{
    public ParticleSystem deathParticles;
    private Animation animator;
    private AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animation>();
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.name == "AttackCollider") {
            Destroy(GetComponent<EnemyWander>());
            animator.Stop();
            animator.Play("death1");
            if (sound!=null) {
                sound.Play();
            }
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter() {
        yield return new WaitForSecondsRealtime(.5f);
        Instantiate(deathParticles, transform.position, Quaternion.identity);
        yield return new WaitForSecondsRealtime(.5f);
        Destroy(gameObject);
    }
}

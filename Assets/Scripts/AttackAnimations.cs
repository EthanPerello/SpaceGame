using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimations : MonoBehaviour
{
    private Animator animator;
    private AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        sound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            if (sound!= null) {
                sound.Play();
            }
            animator.SetTrigger("Attack");
            Attack.attacked = true;
        }
    }
}

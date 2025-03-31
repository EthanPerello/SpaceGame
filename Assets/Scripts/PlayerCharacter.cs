using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCharacter : MonoBehaviour
{
    public static float fullHealth = 100f;
    public static float currentHealth = fullHealth;

    public static float currentGems = 0;

    public static bool damaged;

    Animator animator;

    AudioSource deathsound;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        deathsound = GameObject.Find("PlayerDeathSound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0) {
            if (deathsound!=null) {
                deathsound.Play();
            }
            Destroy(GetComponent<CharacterController>());
            animator.SetBool("NotDead", false);
            animator.SetTrigger("Dead");
            StartCoroutine(waiter());
        }

        if (currentGems >= 5) {
            SceneManager.LoadScene("Win");
            currentGems = 0;
            currentHealth = 100;
        }

        if (damaged == true){
            animator.SetTrigger("Hit");
            currentHealth -= 25;
            damaged = false;
        }
    }

    IEnumerator waiter() {
        yield return new WaitForSecondsRealtime(1.5f);
        SceneManager.LoadScene("GameOver");
        currentGems = 0;
        currentHealth = 100;
        animator.SetBool("NotDead", true);
    }
}

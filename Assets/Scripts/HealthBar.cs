using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private float fullHealth = PlayerCharacter.fullHealth;
    private float currentHealth = PlayerCharacter.currentHealth;
    private Image healthBar;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = PlayerCharacter.currentHealth;
        healthBar.fillAmount = currentHealth / fullHealth;
    }
}

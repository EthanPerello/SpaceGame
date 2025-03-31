using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemsCollected : MonoBehaviour
{
    public float totalGems = 5;
    private float currentGems = PlayerCharacter.currentGems;
    private Image gemsCollected;
    // Start is called before the first frame update
    void Start()
    {
        gemsCollected = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        currentGems = PlayerCharacter.currentGems;
        gemsCollected.fillAmount = currentGems / totalGems;
    }
}

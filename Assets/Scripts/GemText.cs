using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GemsText : MonoBehaviour
{
    public float totalGems = 5;
    private float currentGems = PlayerCharacter.currentGems;
    private TMPro.TextMeshProUGUI gemsCollected;
    // Start is called before the first frame update
    void Start()
    {
        gemsCollected = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        currentGems = PlayerCharacter.currentGems;
        gemsCollected.text = Convert.ToString(currentGems) + "/" + Convert.ToString(totalGems);
    }
}

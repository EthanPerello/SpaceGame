using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Collider attackCollider;
    public static bool attacked = false;
    // Start is called before the first frame update
    void Start()
    {
        attackCollider = gameObject.GetComponent<Collider>();
        attackCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (attacked == true) {
            StartCoroutine(waiter());
            attacked = false;
        }
    }
    
    IEnumerator waiter()
    {   yield return new WaitForSecondsRealtime(.2f);
        attackCollider.enabled = true;
        yield return new WaitForSecondsRealtime(.8f);
        attackCollider.enabled = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    private bool walkRight = false;
    private bool walkLeft = false;
    private bool walkForward = false;
    private bool walkBackwards = false;
    private bool idle = true;

    private string lastMove;

    public int speed;
    
    private float waitTime = 5.0f;

    private Animation myAnimation;
    // Start is called before the first frame update
    void Start()
    {
        myAnimation = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (walkRight == true) {
            myAnimation.Play("walk");
            Vector3 temp = new Vector3(.001f*speed,0,0);
            gameObject.transform.position += temp;
            gameObject.transform.eulerAngles = new Vector3(
                gameObject.transform.eulerAngles.x,
                90,
                gameObject.transform.eulerAngles.z
            );
        }
        if (walkLeft == true) {
            myAnimation.Play("walk");
            Vector3 temp = new Vector3(-.001f*speed,0,0);
            gameObject.transform.position += temp;
            gameObject.transform.eulerAngles = new Vector3(
                gameObject.transform.eulerAngles.x,
                -90,
                gameObject.transform.eulerAngles.z
            );
        }
        if (walkForward == true) {
            myAnimation.Play("walk");
            Vector3 temp = new Vector3(0,0,.001f*speed);
            gameObject.transform.position += temp;
            gameObject.transform.eulerAngles = new Vector3(
                gameObject.transform.eulerAngles.x,
                0,
                gameObject.transform.eulerAngles.z
            );
        }
        if (walkBackwards == true) {
            myAnimation.Play("walk");
            Vector3 temp = new Vector3(0,0,-.001f*speed);
            gameObject.transform.position += temp;
            gameObject.transform.eulerAngles = new Vector3(
                gameObject.transform.eulerAngles.x,
                180,
                gameObject.transform.eulerAngles.z
            );
        }
        if (idle == true) {
            myAnimation.Play("idle");
        }

        waitTime -= Time.deltaTime;
        if (waitTime <= 0.0f) {
            int randNum = Random.Range(1,5);
            if (randNum == 1) {
                idle = true;
                walkRight = false;
                walkLeft = false;
                walkForward = false;
                walkBackwards = false;
            }
            if ((randNum == 2) && (lastMove != "walkRight")) {
                idle = false;
                walkRight = true;
                walkLeft = false;
                walkForward = false;
                walkBackwards = false;
                lastMove = "walkRight";
            }
            if ((randNum == 3) && lastMove != "walkLeft") {
                idle = false;
                walkRight = false;
                walkLeft = true;
                walkForward = false;
                walkBackwards = false;
                lastMove = "walkLeft";
            }
            if ((randNum == 4) && lastMove != "walkForward") {
                idle = false;
                walkRight = false;
                walkLeft = false;
                walkForward = true;
                walkBackwards = false;
                lastMove = "walkForward";
            }
            if ((randNum == 5) && lastMove != "walkBackwards") {
                idle = false;
                walkRight = false;
                walkLeft = false;
                walkForward = false;
                walkBackwards = true;
                lastMove = "walkBackwards";
            }
            waitTime = 5.0f;
        }
    }

    void OnTriggerEnter(Collider other) {
        idle = true;
        walkRight = false;
        walkLeft = false;
        walkForward = false;
        walkBackwards = false;
    }
}

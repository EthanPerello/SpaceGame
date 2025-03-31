using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyWander : MonoBehaviour
{
    GameObject player;
    NavMeshAgent agent;
    [SerializeField] LayerMask groundLayer, playerLayer;
    AudioSource attacksound;

    Animation animator;

    BoxCollider attackCollider;

    Vector3 destPoint;
    bool walkpointSet;
    [SerializeField] float range;

    [SerializeField] float sightRange, attackRange;
    bool playerInSight, playerInAttackRange;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        animator = GetComponent<Animation>();
        attackCollider = GetComponent<BoxCollider>();
        attacksound = GameObject.Find("SpiderAttackSound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        playerInSight = Physics.CheckSphere(transform.position, sightRange, playerLayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, playerLayer);

        if (!playerInSight && !playerInAttackRange) Wander();
        if (playerInSight && !playerInAttackRange) Chase();
        if (playerInAttackRange) Attack();
    }

    void Chase() {
        animator.Play("walk");
        agent.SetDestination(player.transform.position);
        attackCollider.enabled = false;
    }

    void Attack() {
        if (attacksound!=null){
            attacksound.Play();
        }
        animator.Play("attack1");
        agent.SetDestination(transform.position);
        attackCollider.enabled = true;
    }

    void Wander()
    {
        animator.Play("walk");
        if (!walkpointSet) SearchForDest();
        if (walkpointSet) agent.SetDestination(destPoint);
        if (Vector3.Distance(transform.position, destPoint) < 10) walkpointSet = false;
        attackCollider.enabled = false;
    }

    void SearchForDest()
    {
        float z = Random.Range(-range,range);
        float x = Random.Range(-range,range);

        destPoint = new Vector3(transform.position.x + x, transform.position.y,transform.position.z + z);

        if (Physics.Raycast(destPoint, Vector3.down, groundLayer)) {
            walkpointSet = true;
        }
    }

    private void OnTriggerEnter(Collider other){
        if (other.name == "Player"){
            PlayerCharacter.damaged = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Minion_1 : MonoBehaviour
{
    public float health = 10f;
    public void TakeDamage(float amount){
        health -= amount;
        if(health <= 0f){
            Destroy(gameObject);
        }
    }
    private NavMeshAgent navMeshAgent;
    [SerializeField] private Transform movePositionTransform;
    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        //rb.velocity=new Vector3(2,0,0);
        navMeshAgent.destination = movePositionTransform.position;
        
    }

    void OnCollisionEnter(Collision otherObj) {
        if (otherObj.gameObject.tag == "Player") {
            Destroy(gameObject);
        }
    }
}

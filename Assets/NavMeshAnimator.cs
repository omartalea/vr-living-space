using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAnimator : MonoBehaviour
{   
    public NavMeshAgent agent;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Speed", agent.velocity.magnitude);    
    }
}


﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WizardMovement : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;

    public GameObject possibleTargets;
    public GameObject curTarget;
    //Vector3 curTarget;

    private void Start()
    {

    }

    void Update()
    {
        /*float distanceToTarget = Vector3.Distance(gameObject.transform.position, curTarget);
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouse = Input.mousePosition;
            Ray castPoint = Camera.main.ScreenPointToRay(mouse);
            RaycastHit hit;
            if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
            {
                curTarget = hit.point;
                navMeshAgent.SetDestination(curTarget);
            }
        }
        else if (distanceToTarget < 3 || curTarget == Vector3.zero)
        {
            FindNewTarget();
        }*/

        print("I should start");
        navMeshAgent.SetDestination(curTarget.transform.position);
        navMeshAgent.destination = curTarget.transform.position;

        print(navMeshAgent.destination);
    }

    /*public void FindNewTarget()
    {
        int random = Random.Range(0, possibleTargets.transform.childCount - 1);
        Vector3 nextTarget = possibleTargets.transform.GetChild(random).position;
        curTarget = nextTarget;
        navMeshAgent.SetDestination(curTarget);
    }*/
}

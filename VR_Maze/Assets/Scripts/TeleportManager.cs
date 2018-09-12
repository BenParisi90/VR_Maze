using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportManager : MonoBehaviour {

    public GameObject activeMovePoint;

    public List<GameObject> movePoints = new List<GameObject>();

    float maxMoveDistance = GvrReticlePointer.RETICLE_DISTANCE_MAX;

    Animator eyelidAnimator;

    bool usesEyelids = true;

	// Use this for initialization
	void Start () {
        GameObject eyelids = GameObject.Find("eyelids");
        if(eyelids == null)
        {
            usesEyelids = false;
        }
        else
        {
            eyelidAnimator = eyelids.GetComponent<Animator>();
        }
        UseMovePoint(activeMovePoint, false);
       
    }
	
	public void UseMovePoint(GameObject targetPoint, bool playBlink = true)
    {
        //play the eyelid aniamtion
        if (playBlink && usesEyelids)
        {
            eyelidAnimator.Play("blink");
        }
        //turn off all the move points that are not in range
        foreach (GameObject movePoint in movePoints)
        {
            if (Vector3.Distance(targetPoint.transform.position, movePoint.transform.position) > maxMoveDistance)
            {
                movePoint.SetActive(false);
            }
            else
            {
                movePoint.SetActive(true);
            }
        }

        //turn off the active move point
        if (activeMovePoint != null)
        {
                activeMovePoint.SetActive(true);
        }
        activeMovePoint = targetPoint;
        activeMovePoint.SetActive(false);
    }
}

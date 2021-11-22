﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class CarDestruction : MonoBehaviour
{
    [SerializeField]
    Transform carRoof;
    [SerializeField]
    Transform carTrunk;
    [SerializeField]
    Transform carHood;
    [SerializeField]
    Transform carDoor;
    [SerializeField]
    Transform carWindowBack;
    [SerializeField]
    Transform carLights;
    [SerializeField]
    Transform bumper;

    static int hitCounter;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Wall"))
        {
            hitCounter++;

            if (hitCounter==1)
            {
                carHood.GetComponent<Rigidbody>().isKinematic = false;
                carHood.GetComponent<Rigidbody>().AddForce(Vector3.up * 30f, ForceMode.Impulse);
                carHood.transform.parent = null;
            }
            else if(hitCounter==2)
            {
                carDoor.GetComponent<Rigidbody>().isKinematic = false;
                carDoor.GetComponent<Rigidbody>().AddForce(Vector3.left * 10f, ForceMode.Impulse);

                carDoor.transform.parent = null;
            }
            else if (hitCounter == 3)
            {
                carRoof.GetComponent<Rigidbody>().isKinematic = false;
                carRoof.GetComponent<Rigidbody>().AddForce(Vector3.up * 30f, ForceMode.Impulse);

                carRoof.transform.parent = null;
            }



            else if (hitCounter == 4)
            {
                carWindowBack.GetComponent<Rigidbody>().isKinematic = false;
                carWindowBack.transform.parent = null;
            }
            else if (hitCounter == 5)
            {
                bumper.GetComponent<Rigidbody>().isKinematic = false;
                bumper.transform.parent = null;
            }
            other.gameObject.transform.DOScale(Vector3.zero, 0.25f);
           
            
            
            
           
            
            
            
           
            


        }
    }
}

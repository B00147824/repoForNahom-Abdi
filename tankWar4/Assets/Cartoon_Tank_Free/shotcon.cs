using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotcon : MonoBehaviour
{
   
    void Start()
    {

    GetComponent<Rigidbody>().velocity = transform.forward * 12; 
    Destroy(gameObject, 5);
    }

    void Update()

        {

        }
        
 }

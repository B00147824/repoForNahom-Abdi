using System. Collections; 
using System. Collections.Generic; 
using UnityEngine;

public class enemy : MonoBehaviour

{

public Transform shot;
void Start()
{
   StartCoroutine(delayShot());
}
void Update( )	


{ 
    transform.LookAt (hero. currentPos) ;

	GetComponent<Rigidbody>().velocity = transform. forward * 1.7f;
}



IEnumerator delayShot ()
{

yield return new WaitForSeconds (4);
Instantiate(shot, new Vector3(transform.position.x,1.57f, transform.position.z), transform.rotation);
StartCoroutine(delayShot());
}




}
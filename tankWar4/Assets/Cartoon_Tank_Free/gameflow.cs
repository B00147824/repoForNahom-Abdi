using System. Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using TMPro;

public class gameflow : MonoBehaviour
{


        public GameObject[] tank; 
        private int whichTank; 
        
        void Start()
        {

        StartCoroutine(spawnTimer());
        }

        void Update()

        {
        }

        IEnumerator spawnTimer ()
        {
        yield return new WaitForSeconds(4);
         whichTank =Random.Range(0,3);
          Instantiate(tank [ whichTank ]); 
          whichTank =Random. Range(0,3); 
          Instantiate(tank[whichTank]);
        StartCoroutine(spawnTimer());
        }
}
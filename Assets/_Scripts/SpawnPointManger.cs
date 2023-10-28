 using UnityEngine;

     public class SpawnPointManager : MonoBehaviour {
         private GameObject[] spawnPoints;

         void Start() {
             spawnPoints = GameObject.FindGameObjectsWithTag("Respawn");
             // logError if array empty
             if(spawnPoints.Length < 1)
                 Debug.LogError ("SpawnPointManagaer - cannot find any objects tagged 'Respawn'");

         }

         public GameObject RandomSpawnPoint() {
             if(spawnPoints.Length < 1) 
                 return null;
             int r = Random.Range(0, spawnPoints.Length);
             return spawnPoints[r];
             // return current GameObject if array empty
                 

                 // the rest as before ... 

         }
         
         public GameObject GetNearestSpawnpoint (Vector3 source){
             if(spawnPoints.Length < 1)
                 return null;
             GameObject nearestSpawnPoint = spawnPoints[0];
             Vector3 spawnPointPos = spawnPoints[0].transform.position;
             float shortestDistance = Vector3.Distance(source, spawnPointPos);

             for (int i = 1; i < spawnPoints.Length; i++){
                 spawnPointPos = spawnPoints[i].transform.position;
                 float newDist = Vector3.Distance(source, spawnPointPos);
                 if (newDist < shortestDistance){
                     shortestDistance = newDist;
                     nearestSpawnPoint = spawnPoints[i];
                 }
             }
             
             return nearestSpawnPoint;
         } 
     }





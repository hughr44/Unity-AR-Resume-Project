using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner1 : MonoBehaviour
{
    public int spawnNum;
    public GameObject objectToSpawn1;
    public GameObject objectToSpawn2;
    public GameObject objectToSpawn3;
    private PlacementIndicator placementIndicator;

    void Start() {
        spawnNum = 1;
        placementIndicator = FindObjectOfType<PlacementIndicator>();
    }

    void Update() { 
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            if ((spawnNum + 2) % 3 == 0)
            {
                GameObject obj = Instantiate(objectToSpawn1, placementIndicator.transform.position, placementIndicator.transform.rotation);
            }
            if ((spawnNum + 1) % 3 == 0)
            {
                GameObject obj = Instantiate(objectToSpawn2, placementIndicator.transform.position, placementIndicator.transform.rotation);
            }
            if ((spawnNum) % 3 == 0)
            {
                GameObject obj = Instantiate(objectToSpawn3, placementIndicator.transform.position, placementIndicator.transform.rotation);
            }
            spawnNum++;
        }
    }
}

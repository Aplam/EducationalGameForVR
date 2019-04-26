using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBread : MonoBehaviour
{
	public Transform spawnPos;
	public GameObject objToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



	public void dropBread(){
		Instantiate(objToSpawn, spawnPos.position, spawnPos.rotation);
	}
}

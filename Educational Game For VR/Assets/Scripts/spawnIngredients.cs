using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnIngredients : MonoBehaviour
{
	public Transform spawnPos;
	public GameObject breadToSpawn;
    public GameObject tomatoToSpawn;
    public GameObject cheeseToSpawn;
    public GameObject hamToSpawn;
    public GameObject lettuceToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        breadToSpawn = GameObject.Find("breadslice");
        tomatoToSpawn = GameObject.Find("tomato");
        cheeseToSpawn = GameObject.Find("cheese");
        hamToSpawn = GameObject.Find("ham");
        lettuceToSpawn = GameObject.Find("lettuce");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dropBread(){
        Instantiate(breadToSpawn, spawnPos.position, spawnPos.rotation);
    }

    public void dropTomato(){
		Instantiate(tomatoToSpawn, spawnPos.position, spawnPos.rotation);
	}

    public void dropCheese()
    {
        Instantiate(cheeseToSpawn, spawnPos.position, spawnPos.rotation);
    }

    public void dropHam()
    {
        Instantiate(hamToSpawn, spawnPos.position, spawnPos.rotation);
    }

    public void dropLettuce()
    {
        Instantiate(lettuceToSpawn, spawnPos.position, spawnPos.rotation);
    }
}

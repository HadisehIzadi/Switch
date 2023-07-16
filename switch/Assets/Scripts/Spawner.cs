using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	// variables
	public GameObject prefab, Star;
	public float spawnRate = 1.6f;
	int x , y;
	float gameSpeed = 1.5f;
	
	GameObject pipes , stars;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
    	gameSpeed -= 0.5f;
    	if(gameSpeed == 0)
    		gameSpeed = 1f;
    }
    
    
    void OnEnable()
    {
    	InvokeRepeating(nameof(Spawn) , spawnRate , spawnRate * gameSpeed);
    }
    
    void OnDisable()
    {
    	CancelInvoke(nameof(Spawn));
    }
    
    void Spawn()
    {
    	System.Random rnd = new System.Random();
    	x = Random.Range(0 , 2);
    	y = Random.Range(0 , 2);
    	
    	if(x < 1 && x >= 0)
    	{
    		pipes = Instantiate(prefab,transform.position,Quaternion.identity);
    		if(y < 1 && y >= 0)
    			 stars = Instantiate(Star,transform.position,Quaternion.identity);
    	}

    	else
    	{
    		prefab.transform.position = new Vector3( -transform.position.x ,transform.position.y ,transform.position.z);
    		pipes = Instantiate(prefab,prefab.transform.position,Quaternion.identity);
    		
    		if(y < 1 && y >= 0)
    			 stars = Instantiate(Star,transform.position,Quaternion.identity);
    		
    	}
    	
    	pipes.transform.position += Vector3.down * Random.Range(-1f , 1f);
    	
    	
    		
    	
    	
    	
    }


}

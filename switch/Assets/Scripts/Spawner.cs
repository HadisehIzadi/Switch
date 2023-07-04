using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	// variables
	public GameObject prefab;
	public float spawnRate = 1.6f;
	int x;
	
	GameObject pipes;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    void OnEnable()
    {
    	InvokeRepeating(nameof(Spawn) , spawnRate , spawnRate);
    }
    
    void OnDisable()
    {
    	CancelInvoke(nameof(Spawn));
    }
    
    void Spawn()
    {
    	System.Random rnd = new System.Random();
    	x = Random.Range(0 , 2);
    	
    	if(x < 1 && x >= 0)
    	{
    		pipes = Instantiate(prefab,transform.position,Quaternion.identity);
    	}

    	else
    	{
    		prefab.transform.position = new Vector3( -transform.position.x ,transform.position.y ,transform.position.z);
    		pipes = Instantiate(prefab,prefab.transform.position,Quaternion.identity);
    		
    	}
    	
    	pipes.transform.position += Vector3.down * Random.Range(-1f , 1f);
    	
    	
    		
    	
    	
    	
    }


}

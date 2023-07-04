using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	private Vector3 pos;
	public GameObject gameover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(Input.GetMouseButtonDown(0))
    	{
    		pos = new Vector3( -transform.position.x ,transform.position.y ,transform.position.z);
    		transform.position = pos;
    	}
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
    	Debug.Log("collision happened");
    	if(other.gameObject.tag == "Obstracle")
    		gameover.SetActive(true);
    		
    }
}

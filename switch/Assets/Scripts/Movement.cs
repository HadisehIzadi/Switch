using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Movement : MonoBehaviour
{
	private Vector3 pos;
	public GameObject gameover;
	int score;
	float  currentTime;
	public Text scoreText;
	
    // Start is called before the first frame update
    void Start()
    {
    	PlayerPrefs.SetInt("Score", 0);
         scoreText.text = PlayerPrefs.GetInt("Score", 0).ToString();
         currentTime = 0f;
         
    }

    // Update is called once per frame
    void Update()
    {
    	if(Input.GetMouseButtonDown(0))
    	{
    		if (transform.position.x == 2.65f)
    		{
    			Debug.Log(" x== 2.65 ");
    			while(transform.position.x > -2.65f){
    				transform.Translate( Vector3.left * 1 * Time.deltaTime );
    				
    			}
    			
    			transform.position = new Vector3( -2.65f ,transform.position.y ,transform.position.z);
    			
    			
    			
    		}
    		else if (transform.position.x == -2.65f)
    		{
    			Debug.Log(" x== -2.65 ");
    			while(transform.position.x  < 2.65f){
    				transform.Translate( Vector3.right * 1 * Time.deltaTime );
    				
    			}
    			transform.position = new Vector3( 2.65f ,transform.position.y ,transform.position.z);
    			//break;
    		}
    		
//    		pos = new Vector3( -transform.position.x ,transform.position.y ,transform.position.z);
//    		transform.position = pos;
    	}
    	currentTime += Time.deltaTime;
    	if( currentTime >= 3f )
         {
    		AddToScore();
             currentTime = 0 ;
         }
        

    	
    }



    
    void AddToScore()
    {
    	score += 1 ;
    	PlayerPrefs.SetInt("Score", score);
    	 scoreText.text = PlayerPrefs.GetInt("Score", 0).ToString();
    	
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
    	Debug.Log("collision happened");
    	if(other.gameObject.tag == "Obstracle")
    		gameover.SetActive(true);
    	
    	else if(other.gameObject.tag == "Star")
    	{
    		Destroy(other.gameObject);
    		score += 10;
    		PlayerPrefs.SetInt("Score", score);
    		 scoreText.text = PlayerPrefs.GetInt("Score", 0).ToString();
    	}
    		
    }
}

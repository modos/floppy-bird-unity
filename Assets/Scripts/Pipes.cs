using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{

	private BoxCollider2D box;
	private Rigidbody2D rigid;
	
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
		rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BirdController.isDead == false){
			
			rigid.velocity = new Vector2(-2.0f, 0);
		}else {
			rigid.velocity = Vector2.zero;
		}
    }
	
	void OnTriggerEnter2D(Collider2D other){
		if (other.GetComponent<BirdController>() != null){
			BirdController.score++;
		}
	}
}

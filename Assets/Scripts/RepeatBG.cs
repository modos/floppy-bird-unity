using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBG : MonoBehaviour
{

	private BoxCollider2D box;
	private Rigidbody2D rigid;
    // Start is called before the first frame update
    void Awake()
    {
        box = GetComponent<BoxCollider2D>();
		rigid = GetComponent<Rigidbody2D>();
		
		rigid.velocity = new Vector2(-2f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (BirdController.isDead == false){
			if (transform.position.x < -box.size.x){
				Vector2 offset = new Vector2(box.size.x * 2f, 0);
				transform.position = (Vector2) transform.position + offset;
			}
		}else {
			rigid.velocity = Vector2.zero;
		}
    }
}

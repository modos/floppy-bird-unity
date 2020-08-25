using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{

	public float force;
	public static bool isDead = false;
	
	private Rigidbody2D rigid;
	private AudioSource audio;
	public static int score;
	
	public Text text;
	public Text gameover_text;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
		audio = GetComponent<AudioSource>();
		isDead = false;
		gameover_text.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false){

			if (Input.GetMouseButtonDown(0)){
				rigid.velocity = Vector2.zero;
				rigid.AddForce(new Vector2(0, force));
				audio.Play();
				text.text = "Score : " + score.ToString();
			}
		}else {
			 isDead = true;
			 gameover_text.gameObject.SetActive(true);
			 if (Input.GetMouseButtonDown(0)){
			 	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
			 }
		}
    }
	
	void OnCollisionEnter2D(Collision2D other){
		rigid.velocity = Vector2.zero;
		isDead = true;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatCol : MonoBehaviour
{

	public GameObject prefab;
	public int size = 4;
	public float rate = 3;
	public float minY = -0.5f;
	public float maxY = 3.0f;
	
	public GameObject[] columns;
	private float timeSinceLastSpawned;
	
	private int current = 0;
	
    // Start is called before the first frame update
    void Start()
    {
        timeSinceLastSpawned = 0f;
		
		columns = new GameObject[size];
		
		for(int i = 0; i < size; i++){
			columns[i] = (GameObject) Instantiate(
				prefab, new Vector2(-20, -20), Quaternion.identity);
				
		}
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
		
		if (BirdController.isDead == false &&
			timeSinceLastSpawned >= rate){
				timeSinceLastSpawned = 0f;
				
				float spawnY = Random.Range(minY, maxY);
				
				columns[current].transform.position = new Vector2(10f, spawnY);
				
				current++;
				
				if (current >= size){
					current = 0;
				}
			}
    }
}

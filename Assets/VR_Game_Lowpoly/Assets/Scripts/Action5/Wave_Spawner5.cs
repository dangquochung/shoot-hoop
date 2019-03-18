using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave_Spawner5 : MonoBehaviour {

	public Transform enemyPrefab5;
	public Transform spawnPoint5;
	public float timeBetweenWaves = 5f;
	private float countdown = 2f;
	private int waveNumber=0;
	void Update(){
		if (countdown <= 0f) {
			SpawnWave5 ();
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;
	}

	void SpawnWave5(){
		for(int i=0;i<waveNumber;i++){
			SpawnEnemy5 ();
		}
		waveNumber++;
	}

	void SpawnEnemy5()
	{
        if (enemyPrefab5 != null && spawnPoint5 != null)
            Instantiate (enemyPrefab5, spawnPoint5.position,spawnPoint5.rotation);
	}

}

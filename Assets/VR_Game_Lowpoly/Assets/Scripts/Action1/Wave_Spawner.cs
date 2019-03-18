using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave_Spawner : MonoBehaviour {
	
	public Transform enemyPrefab;
	public Transform spawnPoint;
	public float timeBetweenWaves = 5f;
	private float countdown = 2f;
	private int waveNumber=0;
	void Update(){
		if (countdown <= 0f) {
			SpawnWave ();
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;
	}

	void SpawnWave(){
		for(int i=0;i<waveNumber;i++){
			SpawnEnemy ();
		}
		waveNumber++;
	}

	void SpawnEnemy()
	{
        if (enemyPrefab != null && spawnPoint != null)
            Instantiate (enemyPrefab, spawnPoint.position,spawnPoint.rotation);
	}

}

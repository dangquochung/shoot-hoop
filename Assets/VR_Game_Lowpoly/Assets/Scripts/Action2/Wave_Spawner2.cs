using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave_Spawner2 : MonoBehaviour {

	public Transform enemyPrefab2;
	public Transform spawnPoint2;
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
        if (enemyPrefab2 != null && spawnPoint2 != null)
            Instantiate (enemyPrefab2, spawnPoint2.position,spawnPoint2.rotation);
	}

}

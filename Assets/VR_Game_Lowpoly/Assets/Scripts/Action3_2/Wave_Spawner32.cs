using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave_Spawner32 : MonoBehaviour {

	public Transform enemyPrefab32;
	public Transform spawnPoint32;
	public float timeBetweenWaves = 5f;
	private float countdown = 2f;
	private int waveNumber=0;
	void Update(){
		if (countdown <= 0f) {
			SpawnWave32 ();
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;
	}

	void SpawnWave32(){
		for(int i=0;i<waveNumber;i++){
			SpawnEnemy32 ();
		}
		waveNumber++;
	}

	void SpawnEnemy32()
	{
        if (enemyPrefab32 != null && spawnPoint32 != null)
            Instantiate (enemyPrefab32, spawnPoint32.position,spawnPoint32.rotation);
	}

}

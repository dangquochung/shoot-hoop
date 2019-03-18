using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave_Spawner4 : MonoBehaviour {

	public Transform enemyPrefab4;
	public Transform spawnPoint4;
	public float timeBetweenWaves = 5f;
	private float countdown = 2f;
	private int waveNumber=0;
	void Update(){
		if (countdown <= 0f) {
			SpawnWave4 ();
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;
	}

	void SpawnWave4(){
		for(int i=0;i<waveNumber;i++){
			SpawnEnemy4 ();
		}
		waveNumber++;
	}

	void SpawnEnemy4()
	{
        if (enemyPrefab4 != null && spawnPoint4 != null)
            Instantiate (enemyPrefab4, spawnPoint4.position,spawnPoint4.rotation);
	}

}

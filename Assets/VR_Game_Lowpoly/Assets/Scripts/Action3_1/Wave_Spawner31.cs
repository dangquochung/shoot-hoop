using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave_Spawner31 : MonoBehaviour {

	public Transform enemyPrefab31;
	public Transform spawnPoint31;
	public float timeBetweenWaves = 5f;
	private float countdown = 2f;
	private int waveNumber=0;
	void Update(){
		if (countdown <= 0f) {
			SpawnWave31 ();
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;
	}

	void SpawnWave31(){
		for(int i=0;i<waveNumber;i++){
			SpawnEnemy31 ();
		}
		waveNumber++;
	}

	void SpawnEnemy31()
	{
        if(enemyPrefab31 != null && spawnPoint31 != null)
		Instantiate (enemyPrefab31, spawnPoint31.position,spawnPoint31.rotation);
	}

}

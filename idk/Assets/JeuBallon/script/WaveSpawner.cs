using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {

    [SerializeField]
    private Transform spawn;

    [SerializeField]
    public Transform spawnPoint;

    private float timeBetweenWave;

    private float countdown;
    private int waveNumber;
    public static bool isActive;
	
	// Update is called once per frame
    void Start()
    {
        timeBetweenWave = Random.Range(5f, 6f);
        isActive = true;
        countdown = 2f;
        waveNumber = 1;
    }

	void Update () {
        if (isActive)
        {
            if (countdown <= 0f)
            {
                SpwanWave();
                if (ScoreManager.score == 6)
                    timeBetweenWave = Random.Range(4f, 5f);
                if (ScoreManager.score == 10)
                    timeBetweenWave = Random.Range(3f, 4f);
                if (ScoreManager.score == 15)
                    timeBetweenWave = Random.Range(2f, 4f);
                countdown = timeBetweenWave;
            }
            countdown -= Time.deltaTime;
        }
	}

    void SpwanWave()
    {

        SpawnSphere();
        waveNumber++;
    }

    void SpawnSphere()
    {
        Vector3 pos = new Vector3(Random.Range(50,460) , 200, 69);
        print("la pos de spawn: " + spawnPoint.position);
        Instantiate(spawn,pos,spawnPoint.rotation);
    }
}

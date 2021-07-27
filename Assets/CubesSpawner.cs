using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubesSpawner : MonoBehaviour
{
	[SerializeField] GameObject cubePrefab;
	[SerializeField] InputField magnField; 
	[SerializeField] InputField angleField; 
	[SerializeField] InputField distField; 
    public void SpawnCube() {
		CubeSetUp cubeSetUp = Instantiate(cubePrefab).GetComponent<CubeSetUp>();
		float speed = System.Single.Parse(magnField.text);
		float angle = System.Single.Parse(angleField.text);
		float dist = System.Single.Parse(distField.text);
		cubeSetUp.SetUp(speed, angle, dist);
	}
}

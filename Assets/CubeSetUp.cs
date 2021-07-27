using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSetUp : MonoBehaviour
{
	Rigidbody rb;

	private void Awake() {
		rb = GetComponent<Rigidbody>();
	}
	public void SetUp(float speed, float angle, float dist) {
		angle = angle / 180 * Mathf.PI;
		Vector3 velocity = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle));
		rb.velocity = velocity;
		float time = dist / speed;

		StartCoroutine(DestroyCor(time));
	}

	IEnumerator DestroyCor(float time) {
		yield return new WaitForSeconds(time);
		Destroy(gameObject);
	}
}

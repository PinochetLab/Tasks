using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
	int score = 0;

	public int GetScore() {
		return score;
	}

	public void AddScore() {
		score++;
		GetComponent<TextUpdator>()?.UpdateText(score.ToString());
	}
}

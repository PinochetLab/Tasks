using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdator : MonoBehaviour
{
	[SerializeField] Text text;
    public void UpdateText(string str) {
		text.text = str;
	}
}

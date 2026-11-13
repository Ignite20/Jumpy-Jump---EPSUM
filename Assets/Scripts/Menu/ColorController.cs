using UnityEngine;
using UnityEngine.UI;

public class ColorController : MonoBehaviour {

	[SerializeField] private Image colorImage;


	public void ToggleColors() {
		Debug.Log("Color Changed!");
		colorImage.color = Random.ColorHSV();
	}

}
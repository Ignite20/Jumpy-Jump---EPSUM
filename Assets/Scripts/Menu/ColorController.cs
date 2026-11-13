using UnityEngine;
using UnityEngine.UI;

public class ColorController : MonoBehaviour {

	[SerializeField] private Image colorImage;


	public void ToggleColors() {
		colorImage.color = Random.ColorHSV();
	}

}
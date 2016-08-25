using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public Transform mainMenu, optionMenu;
	public void LoadScene(string name) {
		Application.LoadLevel (name);
	}
	public void Quit() {
		Application.Quit ();
	}

	public void OptionsMenu(bool clicked) {
		if (clicked == true) {
			optionMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (false);
		} else {
			optionMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (true);
		}
	}
}

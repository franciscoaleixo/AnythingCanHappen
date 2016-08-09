using UnityEngine;
using System.Collections;

public class Cell : MonoBehaviour {
	private int num;
	enum Categories {games, tecnologies, health, envoirement, history, geography, math, GUESS, animes, series, movies, seasonQuestion};

	public int setNum (int numCasa) {
		this.num = numCasa;
	}
}
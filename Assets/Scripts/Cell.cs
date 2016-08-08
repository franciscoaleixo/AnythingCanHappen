using UnityEngine;
using System.Collections;

public class Cell : MonoBehaviour {
	private int num;
	enum Categories {games, tecnologies, health, envoirement, history, geography, math, GUESS, animes, series, movies, seasonQuestion};
	//getter do numero da casa
	public int setNum (int numCasa) {
		this.num = numCasa;
	}
}
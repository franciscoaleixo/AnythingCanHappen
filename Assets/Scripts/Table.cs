using UnityEngine;
using System.Collections;

public class Table : MonoBehaviour {
	private int numCasas;
	private Cell [numCasas] casas;
	private int maxRoundTime;
	//funçao para definir quantas casa tem o jogo (podera haver opçao de quick, normal, long game)
	private void HowManyCells() {
		if (getEscolha() == "Fast") {
			this.numCasas = 20;
		}
		if (getEscolha() == "Normal") {
			this.numCasas = 50;
		}
		if (getEscolha() == "Long") {
			this.numCasas = 100;
		}
	}
}

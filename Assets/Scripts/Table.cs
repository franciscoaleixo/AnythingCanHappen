using UnityEngine;
using System.Collections;

public class Table : MonoBehaviour {
	private int maxRoundTime;
	private Cell[] numCasas;
	public Table(int tamanho) {
		numCasas = new Cell[tamanho];
	}
}

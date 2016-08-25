using UnityEngine;
using System.Collections;

public class Dice : MonoBehaviour {
	private int numberOfMoves;

	public int ThrowDice() {
		numberOfMoves = Random.Range(0,7); // rnd number de 0-6
		return numberOfMoves;
	}
}
using UnityEngine;
using System.Collections;

public class Dice : MonoBehaviour {
	private int numberOfMoves;

	private int ThrowDice() {
		numberOfMoves = rnd.Next (6); // O zero esta incluido, player pode nao mexer
	}
	//Getter do numberOfMoves
	public int getMoves () {
		return this.numberOfMoves;
	}
	public int setMoves (int Moves) {
		this.numberOfMoves = Moves;
	}
}
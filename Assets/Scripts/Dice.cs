﻿using UnityEngine;
using System.Collections;

public class Dice : MonoBehaviour {
	private int numberOfMoves;

	public int ThrowDice() {
		// O zero esta incluido, player pode nao mexer
		numberOfMoves = rnd.Next (6);
	}
	//Getter do numberOfMoves
}
using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
	private Table TabuleiroDeJogo;
	Player [] players;
	private enum GameLenght {FAST, NORMAL, LONG};
	//Funçao para escolher o jogo com interaçao ao humano
	public Game (Player [] players, GameLenght escolha) {
		int tamanho;
		int numPlayers;
		switch(escolha) {
		case "FAST":
			tamanho = 25;
			break;
		case "Normal": 
			tamanho = 50;
			break;
		case "Long":
			tamanho = 100;
			break;
		}
		TabuleiroDeJogo = new Table(tamanho);

		players = new Player[numPlayers];
	}
	void Start () {
	}
} 

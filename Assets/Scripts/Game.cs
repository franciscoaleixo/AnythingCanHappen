using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
	private Table TabuleiroDeJogo;
	Player [] players;
	public enum GameLength {FAST, NORMAL, LONG};
	//Funçao para escolher o jogo com interaçao ao humano
	public Game (Player [] players, GameLength escolha) {
		int tamanho;
		int numPlayers;
		switch(escolha) {
		case GameLength.FAST:
			tamanho = 25;
			break;
		case GameLength.NORMAL: 
			tamanho = 50;
			break;
		case GameLength.LONG:
			tamanho = 100;
			break;

			TabuleiroDeJogo = new Table(tamanho);
			players = new Player[numPlayers];
		}
	}
	void Start () {
	}
} 

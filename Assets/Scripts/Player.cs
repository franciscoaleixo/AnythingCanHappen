using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private string nome; //Player pudera escolher nome
	private Cell location;
	private string Escolha;
	enum escolhaDeJogo {Fast, Normal, Long};
	//Funçao para escolher o jogo com interaçao ao humano
	//Erro
	if (Escolha == "Fast") {
		
	}
	//Erro tambem
	if (escolhaDeJogo == "Normal") {
	
	}
	if(escolhaDeJogo == "Long") {
		
	}
	//Getter e Setters feitos por ter pensado em meter escolhaDeJogo na table e nao no PLayer (a discutir)
	public string setEscolha (string EscolhaDeJogo) {
		this.Escolha = EscolhaDeJogo;
	}
	public string getEscolha() {
		return this.Escolha;
	}
	//Funçao para saber o numero da casa do jogador using cell getter
	//Funçao MovePlayer com Dice.numberOfMoves
}
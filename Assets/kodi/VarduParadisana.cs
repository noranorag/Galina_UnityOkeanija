using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VarduParadisana : MonoBehaviour {
	public string teksts;
	public string teksts2 = "";
	public GameObject ievadesLauks;
	public GameObject ievadesLauks2;
	public GameObject tekstaAttelosana;

	public void uzglabaTekstu() {
		teksts = ievadesLauks.GetComponent<Text>().text;
		teksts2 = ievadesLauks2.GetComponent<Text>().text;

		tekstaAttelosana.GetComponent<Text>().text = "Salas īpašnieks "+teksts.ToUpper()+" ir "+teksts2+" gadus vecs!";

	}
	
}

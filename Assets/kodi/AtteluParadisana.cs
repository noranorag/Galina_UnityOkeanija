using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtteluParadisana : MonoBehaviour {
       public GameObject dzKleita;
	   public GameObject zKleita;
	   public GameObject sKleita;
	   public GameObject rKleita;
	   public GameObject pKronis;
	   public GameObject jCepure;
	   public GameObject mBante;
	   public GameObject aCepure;

	public void AttelosanaAtt(bool vertiba) {
		dzKleita.SetActive(vertiba);
		zKleita.SetActive(vertiba);
		sKleita.SetActive(vertiba);
		rKleita.SetActive(vertiba);
	}

	public void AttelosanaAks(bool vertiba1) {
		pKronis.SetActive(vertiba1);
		jCepure.SetActive(vertiba1);
		mBante.SetActive(vertiba1);
		aCepure.SetActive(vertiba1);
	}

}

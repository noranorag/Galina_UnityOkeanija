using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainiAttelus : MonoBehaviour {
     public GameObject mainigaisAttels;
	 public GameObject mainigaisAttelsA;
	 public GameObject mainigaisAttelsB;
	 public GameObject mainigaisAttelsC;
	 public GameObject mainigaisAttelsD;
	 public GameObject mainigaisAttelsE;

	 public GameObject mainigaisAttelsN;
	 public GameObject mainigaisAttelsO;
	 public GameObject mainigaisAttelsR;



	 public Sprite[] atteluMasivs;
	 public GameObject slaideris;
	 public GameObject slaideris2;

     public void izkritosais(int skaitlis) {
		if(skaitlis == 0) {
			mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
            
			mainigaisAttelsA.GetComponent<Image>().sprite = atteluMasivs[2];
			mainigaisAttelsB.GetComponent<Image>().sprite = atteluMasivs[4];
			mainigaisAttelsC.GetComponent<Image>().sprite = atteluMasivs[6];
			mainigaisAttelsD.GetComponent<Image>().sprite = atteluMasivs[8];
			mainigaisAttelsE.GetComponent<Image>().sprite = atteluMasivs[10];

		} if(skaitlis == 1) {
			mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];

			mainigaisAttelsA.GetComponent<Image>().sprite = atteluMasivs[3];
			mainigaisAttelsB.GetComponent<Image>().sprite = atteluMasivs[5];
			mainigaisAttelsC.GetComponent<Image>().sprite = atteluMasivs[7];
			mainigaisAttelsD.GetComponent<Image>().sprite = atteluMasivs[9];
			mainigaisAttelsE.GetComponent<Image>().sprite = atteluMasivs[11];
		


		} if(skaitlis == 2) {
			mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];

			mainigaisAttelsA.GetComponent<Image>().sprite = atteluMasivs[4];
			mainigaisAttelsB.GetComponent<Image>().sprite = atteluMasivs[6];
			mainigaisAttelsC.GetComponent<Image>().sprite = atteluMasivs[8];
			mainigaisAttelsD.GetComponent<Image>().sprite = atteluMasivs[10];
			mainigaisAttelsE.GetComponent<Image>().sprite = atteluMasivs[12];
		}
	 }

	 public void mainitLielumu() {
		float pasreizejaVertiba2 = slaideris2.GetComponent<Slider>().value;
		float pasreizejaVertiba = slaideris.GetComponent<Slider>().value;
		mainigaisAttels.transform.localScale = new Vector3(1F*pasreizejaVertiba, pasreizejaVertiba2, 1);
		mainigaisAttelsA.transform.localScale = new Vector3(1F*pasreizejaVertiba, pasreizejaVertiba2, 1);
		mainigaisAttelsB.transform.localScale = new Vector3(1F*pasreizejaVertiba, pasreizejaVertiba2, 1);
		mainigaisAttelsC.transform.localScale = new Vector3(1F*pasreizejaVertiba, pasreizejaVertiba2, 1);
		mainigaisAttelsD.transform.localScale = new Vector3(1F*pasreizejaVertiba, pasreizejaVertiba2, 1);
		mainigaisAttelsE.transform.localScale = new Vector3(1F*pasreizejaVertiba, pasreizejaVertiba2, 1);
		mainigaisAttelsN.transform.localScale = new Vector3(1F*pasreizejaVertiba, pasreizejaVertiba2, 1);
		mainigaisAttelsO.transform.localScale = new Vector3(1F*pasreizejaVertiba, pasreizejaVertiba2, 1);
		mainigaisAttelsR.transform.localScale = new Vector3(1F*pasreizejaVertiba, pasreizejaVertiba2, 1);

	 }

	 public void mainitPlatumu() {
		float pasreizejaVertiba2 = slaideris.GetComponent<Slider>().value;
		float pasreizejaVertiba = slaideris2.GetComponent<Slider>().value;
		mainigaisAttels.transform.localScale = new Vector3(pasreizejaVertiba2, 1F*pasreizejaVertiba, 1);
		mainigaisAttelsA.transform.localScale = new Vector3(pasreizejaVertiba2, 1F*pasreizejaVertiba, 1);
		mainigaisAttelsB.transform.localScale = new Vector3(pasreizejaVertiba2, 1F*pasreizejaVertiba, 1);
		mainigaisAttelsC.transform.localScale = new Vector3(pasreizejaVertiba2, 1F*pasreizejaVertiba, 1);
		mainigaisAttelsD.transform.localScale = new Vector3(pasreizejaVertiba2, 1F*pasreizejaVertiba, 1);
		mainigaisAttelsE.transform.localScale = new Vector3(pasreizejaVertiba2, 1F*pasreizejaVertiba, 1);
		mainigaisAttelsN.transform.localScale = new Vector3(pasreizejaVertiba2, 1F*pasreizejaVertiba, 1);
		mainigaisAttelsO.transform.localScale = new Vector3(pasreizejaVertiba2, 1F*pasreizejaVertiba, 1);
		mainigaisAttelsR.transform.localScale = new Vector3(pasreizejaVertiba2, 1F*pasreizejaVertiba, 1);

	 }
}

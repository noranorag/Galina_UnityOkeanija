using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//importe, lai lietotu pointer darbibu interfeisu
using UnityEngine.EventSystems;

//piesaista intereisu

public class AtteluParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler{
	private RectTransform transformKomponente;
	public Canvas kanva;

	// Use this for initialization
	void Start () {
		//Startejot automatiski pieklust attela transform komponentei un piefikse kadas koordinates attels atrodas
		transformKomponente = GetComponent<RectTransform>();
		
	}
	
	public void OnPointerDown (PointerEventData notikums)
	{
		Debug.Log("Izdarīts peles klikšķis uz objekta!");
	} 

	public void OnBeginDrag(PointerEventData notikums)
	{
        Debug.Log("Uzsākta objekta vilkšana!");
    }

	public void OnDrag(PointerEventData notikums)
	{
		Debug.Log("Ņotiek objekta pārveidošana!");
		transformKomponente.anchoredPosition += notikums.delta / kanva.scaleFactor;
	}

	public void OnEndDrag(PointerEventData notikums)
	{
		Debug.Log("Objekta vilkšana pabeigta!");
	}
}

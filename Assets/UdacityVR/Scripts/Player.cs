using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private int numCoins;

    //These objects will appear when 5 coins are collected
    public GameObject[] objectsToInitialize;
    //These objects will disappear when 5 coins are collected
    public GameObject[] objectsToDestroy;
    //Sound to play when temple path is open
    public AudioSource templePathOpenSFX;
	// Use this for initialization
	void Start () {
        numCoins = 0;
	}
	
    /// <summary>
    /// Adds the coin. Checks whether to let the player go to the temple.
    /// </summary>
    public void addCoin(){
        numCoins++;
        if(numCoins == 5){
            foreach(GameObject obj in objectsToInitialize){
                obj.SetActive(true);
            }
            foreach(GameObject obj in objectsToDestroy){
                obj.SetActive(false);
            }
            templePathOpenSFX.Play();
        }
    }
}

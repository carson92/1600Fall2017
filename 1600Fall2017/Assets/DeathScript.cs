using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {
    public float maxHealth = 100;

    public float currentHealth = 100;

    public float maxCoins = 1000;

    public float currCoins = 100;

    public float healthBarLength;
    public float coinCollectBar;
    public GameObject gameOverUI;
    public AudioSource coinSound;
    public AudioClip coinBabing;

 void Start () {
     healthBarLength = Screen.width / 2;
     coinCollectBar = Screen.width / 5;

 }

    void OnGUI(){
     GUI.Box(new Rect(10, 10, healthBarLength, 20), "Health" + currentHealth + "/" + maxHealth); 
     GUI.Box(new Rect(10, 40, coinCollectBar, 20), "Coins" + currCoins + "/" + maxCoins);   
 }
  void Update () {
     AddjustCurrentHealth(0);
     Death ();
     if (GameObject.FindWithTag ("Player") == null)
     {
         Application.LoadLevel(Application.loadedLevel);
     }
     
 }
  public void AddjustCurrentHealth(int adj) {
             currentHealth += adj;    
     
             if (currentHealth < 0)
                     currentHealth = 0;
     
             if (currentHealth > maxHealth)
                     currentHealth = maxHealth;
     
             healthBarLength = (Screen.width / 2) * (currentHealth / (float)maxHealth);
 }
 

public void AddjustCurrentCoins(int adj){
    currCoins += adj;
        if(currCoins < 0)
            currCoins = 0;
        if (currCoins > maxCoins)
        coinCollectBar = (Screen.width / 2) * (currentHealth /(float)maxCoins);
}

     
 public void Death() {
     if (currentHealth == 0) {
         Destroy(gameObject);
         Application.LoadLevel(Application.loadedLevel);
     }
     }
    void OnTriggerEnter(Collider other) {
            if(other.CompareTag("Health")){
			currentHealth += 20;
            }
            if(other.CompareTag("banana")){
            currentHealth -= 20;
            }
           
            if(other.CompareTag("lava")){
                currentHealth -= 100;
            }
            if(currentHealth < 0) {
                print("Dead");
                currentHealth = 0;
            }
            if(currentHealth > 100) {
            currentHealth = 100; 
            
          
            }
            if(other.CompareTag("coin")){
                currCoins += 100;
            }
            if(other.CompareTag("coin")){
			coinSound.PlayOneShot(coinBabing);
            }
            if(other.CompareTag("laser")){
                currentHealth -= 30;
            }
            }
        }       

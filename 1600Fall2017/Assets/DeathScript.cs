using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {
    public float maxHealth = 100;

    public float currHealth = 100;

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
     GUI.Box(new Rect(10, 10, healthBarLength, 20), "Health" + currHealth + "/" + maxHealth); 
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
             currHealth += adj;    
     
             if (currHealth < 0)
                     currHealth = 0;
     
             if (currHealth > maxHealth)
                     currHealth = maxHealth;
     
             healthBarLength = (Screen.width / 2) * (currHealth / (float)maxHealth);
 }
 

public void AddjustCurrentCoins(int adj){
    currCoins += adj;
        if(currCoins < 0)
            currCoins = 0;
        if (currCoins > maxCoins)
        coinCollectBar = (Screen.width / 2) * (currHealth /(float)maxCoins);
}

     
 public void Death() {
     if (currHealth == 0) {
         Destroy(gameObject);
         Application.LoadLevel(Application.loadedLevel);
     }
     }
    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Health")){
            currHealth += 20;
            }
            if(other.CompareTag("banana")){
            currHealth -= 20;
            }
            if(other.CompareTag("lava")){
                currHealth -= 100;
            }
            if(currHealth < 0) {
                print("Dead");
                currHealth = 0;
            }
            if(currHealth > 100) {
            currHealth = 100; 
            
          
            }
            if(other.CompareTag("coin")){
                currCoins += 100;
            }
            if(other.CompareTag("coin")){
			coinSound.PlayOneShot(coinBabing);
            }
            }
        }       

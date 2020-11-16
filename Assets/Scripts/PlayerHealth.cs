using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
   public int totalHealth = 3;
   public RectTransform heartUI;

   private int health;
   private float heartSize = 16f;

   private SpriteRenderer _renderer;

   private void Awake()
   {
   	_renderer = GetComponent<SpriteRenderer>();
   }
   void Start()
   {
   	health = totalHealth;

   }
   public void AddDamage(int amount)
   {
   		health = health - amount;
   		//visual feefback
   		StartCoroutine("VisualFeedback");
   		//Game over
   		if (health <= 0){
   		health = 0;
   		}

   		heartUI.sizeDelta = new Vector2(heartSize * health, heartSize);

   		Debug.Log("Player got demaged. His current health is " + health);
   }
   public void AddHealth (int amount)
   {
   		health = health + amount;

   		//Max healrth 
   		if(health > totalHealth){
   			health = totalHealth;
   		}
   		heartUI.sizeDelta = new Vector2(heartSize * health, heartSize);

   		Debug.Log("Player got some life. His current health is " + health);
   }

   private IEnumerator VisualFeedback()
   {
   	_renderer.color = Color.red;
   	yield return new WaitForSeconds(0.1f);
   	_renderer.color = Color.white;
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NPC.Ally;
using NPC.Enemy;

public class Hero : MonoBehaviour
{
    // Este script contiene el componente que adhiere la camara al heroe, detecta la collision
    // para que cuando el heroe choque con los ciudadanos o los zombies, imprima los mensajes.
	civiles civil;
	Zombies zom;
	void Start () 
	{           
		Camera.main.gameObject.AddComponent<FPSAim>();
	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Zombie")
		{
			Debug.Log ("Hoy toca " + collision.gameObject.GetComponent<Zombie>().zom.part); 
		}
		if (collision.gameObject.tag == "Ciudadano")
		{ 
			Debug.Log ("Mi nombre es " + collision.gameObject.GetComponent<Ciudadano>().civil.name + " y tengo " + collision.gameObject.GetComponent<Ciudadano>().civil.age + " años");
		}
	}
}

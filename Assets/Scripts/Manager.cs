using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NPC.Ally;
using NPC.Enemy;
using UnityEngine.UI;

public class Manager : MonoBehaviour 
{
    // Este script llama las estructuras de los zombies y los ciudadanos, crea las primitivas, le da color
    // a los zombies, les da posiciones random al heroe los zombies y los ciudadanos, y transforma enteros
    // en string para mandar el mensaje.
    Zombies zom;
	civiles civil; 
	Person persona; 
	public Text NZ; 
	public Text NC; 
	public const int MAX = 25; 
	public int NumZombies;
	public int NumCiudadanos;
	public GameObject [] npcss;
	void Start () 
	{
		int P = Random.Range (5, 15);
		persona = new Person (P);
		int caractr = 0;
        zom.col = new Color[]
        {
            Color.cyan, Color.green, Color.magenta
        };
		int rnd2 = Random.Range (persona.Min, MAX); 
		npcss  = new GameObject[rnd2];
		for (int i = 0; i < rnd2; i++)
		{
			GameObject go = GameObject.CreatePrimitive (PrimitiveType.Cube);
			go.AddComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
			Vector3 pos = new Vector3 (Random.Range(-10, 10), 0, Random.Range(-10, 10));  
			go.transform.position = pos; 
			switch (caractr)                                                           
			{
				case 0: 
					go.name = "Hero";
					go.AddComponent<Hero> (); 
					go.AddComponent<FPSMove>();
					Camera.main.gameObject.transform.localPosition = go.transform.position; 
					Camera.main.transform.SetParent(go.transform);
					go.GetComponent<Renderer>().material.color = Color.red;
					go.tag = "Hero";
					break;
				case 1:                                                             
					go.name = "Ciudadano";
					go.AddComponent<Ciudadano> ();
					go.tag = "Ciudadano";
					break;
				case 2:                                                  
					go.name = "Zombie"; 
					go.AddComponent<Zombie> ();
					go.tag = "Zombie";
					int col = Random.Range (0, 3);
					go.GetComponent<Renderer> ().material.color = zom.col [col];
					break;
				default:                            
				go.name = "Ciudadano";
				go.AddComponent<Ciudadano>();
				break;
			}
			caractr = Random.Range(1, 3);
			npcss [i] = go;
		}
		foreach (GameObject pry in npcss)
		{
			GameObject go = pry as GameObject;

			if (go.tag == "Zombie")
			{
				NumZombies += 1; 
			}
			else if (go.tag == "Ciudadano")
			{
				NumCiudadanos += 1;
			}
		}

	}
	void Update()
	{
		NZ.text = NumZombies.ToString (); 
		NC.text = NumCiudadanos.ToString ();
	}
}


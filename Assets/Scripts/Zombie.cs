using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Este script contiene el NPC y el namespace del Enemy, en el cual se le da el movimiento y la rotación random
// en el plano, además de que controla los estados del zombie.
namespace NPC 
{
	namespace Enemy
	{
		public class Zombie : MonoBehaviour
		{
			public Zombies zom;
			int randomint;
			Estado estado;
			public int randomrotation;
			int moving;
			IEnumerator MovimientoZombie ()
			{
				yield return new WaitForSeconds(3);
				estado = (Estado) Random.Range(0,3); 
				randomint = Random.Range(0, 4);
				randomrotation = Random.Range (0, 2);
				StartCoroutine (MovimientoZombie ()); 
			}
			void Start()
			{
				zom.part = (body)Random.Range (0, 5);
				StartCoroutine (MovimientoZombie ());
				zom.Speed = Random.Range(1.7f, 2.3f);
			}
				
		     void Update ()
            { 
				switch (estado) 
				{
					case Estado.idle:
						break;
				case Estado.rotating:
					Rotating ();
						break;
					case  Estado.moving:
						 Moving ();
						break;
				}
			}

			public void Rotating()
			{
				switch (randomrotation) 
				{
				case 0:
					transform.Rotate (0, 1 * zom.Speed, 0);
					break;
				case 1:
					transform.Rotate (0, -1 * zom.Speed, 0);
					break;
				};
			}
				
			public void Moving()
			{

				switch (randomint)
				{
				case 0:
					transform.position += transform.forward * zom.Speed * Time.deltaTime; 
					break;
				case 1:
					transform.position -= transform.forward * zom.Speed * Time.deltaTime;
					break;
				case 2:
					transform.position += transform.right * zom.Speed * Time.deltaTime;
					break;
				case 3:
					transform.position -= transform.right * zom.Speed * Time.deltaTime;
					break;
				}
			}
		}
	}
}
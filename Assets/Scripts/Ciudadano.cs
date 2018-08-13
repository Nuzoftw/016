using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Este script contiene el namespace de los ciudadanos y los datos de ellos, para ponerlos al azar.
namespace NPC
{
	namespace Ally
	{
		public class Ciudadano : MonoBehaviour
		{
			public civiles civil;

			void Start () 
			{
				civil.name = (civilname)Random.Range(1, 20);
				civil.age = Random.Range(15, 101);
			}
		}
	}
}
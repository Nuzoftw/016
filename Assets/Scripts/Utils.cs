using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Este script contiene los enums de los estados, los nombres y la edad de los ciudadanos, las partes que
// desean los zombies y los datos del heroe.
public struct Zombies                                                    
{
	public  Color[] col; 
	public body part; 
	public float Speed; 
	public int randomrotation;
}
public enum body                                           
{
	cabeza, piernas, brazos, torso, cerebro 
}
public enum Estado
{
	idle, moving, rotating
} 
public enum civilname                                           
{
    Norfi, Sindy, Paola, Nuzo, Alirio, Ismael, Celeste, Sara, Mónica,
    Kelly, Santiago, Jacobo, Michael, Anthua, Nayibi, Cony, Margot, Sebastián, Nasly,
    Caca
}
public struct civiles                                              
{
	public int age; 
	public civilname name;
}
public struct Person
{
	public readonly int Min;

	public Person (int random1)
	{
		Min = random1;
	}
}
public struct DatosHero 
{
	public readonly float speed;
	public DatosHero (float speed2)
	{
		speed = speed2;
	}
}


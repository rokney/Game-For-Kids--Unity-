using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour
{
	// Скорость прокрутки
	public Vector2 speed = new Vector2 (2, 2);
	
	// Направление движения
	public Vector2 direction = new Vector2 (-1, 0);
	Plane [] planes;
	Vector3 movement;
		
	void Update ()
	{
		// Перемещение
		movement = new Vector3 (
			speed.x * direction.x,
			speed.y * direction.y,
			0);


		movement *= Time.deltaTime;
		transform.Translate (movement, Space.World);
		planes = GeometryUtility.CalculateFrustumPlanes (Camera.main);
		StartCoroutine (transformObj ());
	}
	// Use this for initialization
	void Start ()
	{

	}
	IEnumerator transformObj(){
		yield return new WaitForSeconds (3f);
		if (GeometryUtility.TestPlanesAABB (planes, GetComponent<Renderer> ().bounds) == false)
		{
			Destroy(gameObject);
		}
	}
			
	// Update is called once per frame

}

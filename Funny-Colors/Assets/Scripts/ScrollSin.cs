using UnityEngine;
using System.Collections;

public class ScrollSin : MonoBehaviour
{
	public float n = 1.0f;
	public Vector2 speed = new Vector2 (1, 0);
	public Vector2 direction = new Vector2 (1, 0);
	Plane [] planes;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{


		planes = GeometryUtility.CalculateFrustumPlanes (Camera.main);
		transform.Translate( new Vector3 (speed.x*direction.x* Time.deltaTime, Mathf.Sin (Time.time)*Time.deltaTime*n, 0.0f));
		planes = GeometryUtility.CalculateFrustumPlanes (Camera.main);
		StartCoroutine (transformObj ());
	}
	IEnumerator transformObj(){
		yield return new WaitForSeconds (2f);
		if (GeometryUtility.TestPlanesAABB (planes, GetComponent<Renderer> ().bounds) == false)
		{
			Destroy(gameObject);
		}
	}
}

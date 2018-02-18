using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trafic : MonoBehaviour {
	public Transform[] objects; 
	float min = 1000;
	Transform nearobj;
	void Start () {
		for (int n = 0; n < objects.Length; n++) {
			float dist = Vector3.Distance(objects[n].position ,  transform.position);
			if(dist < min){
				nearobj = objects[n];
				min = dist;
			}
		}
	}
	

	void Update () {
		Vector3 direction  = nearobj.position - transform.position;
		direction.Normalize();
		transform.Translate(direction * 5 *  Time.deltaTime);
	}
}

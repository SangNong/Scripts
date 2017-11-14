using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popcornSpawn : MonoBehaviour
{
	public GameObject popcornPrefab;
	public Transform spawnPoint;

	void Update (){
		GameObject popcornInstance;
		popcornInstance = Instantiate(popcornPrefab, spawnPoint.position, spawnPoint.rotation) as GameObject;
		popcornInstance.GetComponent<Rigidbody> ().AddForce(spawnPoint.forward * 500);

	}
	}
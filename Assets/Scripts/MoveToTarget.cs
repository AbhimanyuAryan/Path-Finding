using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour {

	private UnityStandardAssets.Characters.ThirdPerson.AICharacterControl AIPlayerTargetScript;
	public GameObject cube;

	// Use this for initialization
	void Start () {
		AIPlayerTargetScript = GetComponent<UnityStandardAssets.Characters.ThirdPerson.AICharacterControl>();
	}
	
	// Update is called once per frame
	void Update () {
		AIPlayerTargetScript.target = cube.transform;
	}
}


/*
	for(int y= 0; y < n -1; y++)
	{
		for(...........)
		{
			if(array[y] > array[y+1])
			{
				int temp = array[y + 1]
			}
		}
	}
*/

/*
Red, Blue, Yellow, Green
 */
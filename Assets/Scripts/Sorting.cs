using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sorting : MonoBehaviour {

	public GameObject[] platforms;
	public GameObject[] aiCharacters; 

	// Use this for initialization
	void Start () {
		//aiCharacters[0] = GameObject.FindGameObjectsWithTag("green"); 
		// print(aiCharacters[0].transform.position);
		// print(platforms[0].transform.position);

		// print(aiCharacters[0].transform.childCount);

		// // This code Get the text number to sort for comparison
		// int i = int.Parse(aiCharacters[0].transform.GetChild(3).GetComponent<ClampName>().nameLabel.text);
		// int first = 2;
		// int second = 3; 
		// if( int.Parse(aiCharacters[first].transform.GetChild(3).GetComponent<ClampName>().nameLabel.text) > 
		// 	int.Parse(aiCharacters[second].transform.GetChild(3).GetComponent<ClampName>().nameLabel.text)) 
		// 	{
		// 		aiCharacters[first].GetComponent<MoveToTarget>().cube = platforms[second];
		// 		aiCharacters[second].GetComponent<MoveToTarget>().cube = platforms[first];
		// 	}
		
		StartCoroutine(BubbleSort());
		
		

		// if number on first character is greater than
		//           move first to second 
		//           move to second to first 

		

		// if(platforms[0].GetComponent<Renderer>().material.color == aiCharacters[2].GetComponent<Renderer>().material.color)
		// {
		// 		print("Both the colors are same ie. red");
		// }
		
		// for(int index = 0; index < 4; index++)
		// {
		// 	if(platforms[index].GetComponent<Renderer>().material.color == aiCharacters[index].transform.GetChild(0).GetComponent<Renderer>().material.color)
		// 	{
		// 		print("both at index " + index + " have a same color");
		// 	}
		// }

		// aiCharacters[0].transform.GetChild(0).GetComponent<Renderer>().material.color = Color.gray; 

		// MVA - Microsoft Virtual Academy

		
	}

	IEnumerator BubbleSort()
	{
		GameObject temp;
		for(int write = 0; write < aiCharacters.Length; write++)
		{
			for(int sort = 0; sort < aiCharacters.Length -1; sort++)
			{
				if( int.Parse(aiCharacters[sort].transform.GetChild(3).GetComponent<ClampName>().nameLabel.text) > 
					int.Parse(aiCharacters[sort + 1].transform.GetChild(3).GetComponent<ClampName>().nameLabel.text)) 
				{
					aiCharacters[sort].GetComponent<MoveToTarget>().cube = platforms[sort + 1];
					aiCharacters[sort + 1].GetComponent<MoveToTarget>().cube = platforms[sort];

					temp = aiCharacters[sort + 1]; 
					aiCharacters[sort + 1] = aiCharacters[sort];
					aiCharacters[sort] = temp; 
					// print("Moving " + sort + " to " + (sort + 1) + " i.e. " + " Characters with number " +
					// int.Parse(aiCharacters[sort].transform.GetChild(3).GetComponent<ClampName>().nameLabel.text) + " is moved ");	
					print("Moving " + (sort + 1) + " to "  + sort);
					yield return new WaitForSeconds(10); 
				}
			}
		}
	}

	// Update is called once per frame
	void Update () {

	}
}


/*

bubble sort should work like 
move element at index first ......to next if its greater if not then
 */
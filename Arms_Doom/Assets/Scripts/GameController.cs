using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {


	// Update is called once per frame
	public static void EndGame () {
		SceneManager.LoadScene( "MVP" );
	}
}

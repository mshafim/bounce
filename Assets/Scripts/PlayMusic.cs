﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour {
    public AudioSource adSource;
	public AudioClip[] adClips;
	private IEnumerator coroutine;

	IEnumerator playAudioSequentially()
	{
		    yield return null;

		    //1.Loop through each AudioClip
		    for (int i = 0; i <= adClips.Length; i++)
		    {
		    	if (i == adClips.Length)
		    	{
		    		i = 0;
		    	}

		        //2.Assign current AudioClip to audiosource
		        adSource.clip = adClips[i];

		        //3.Play Audio
		        adSource.Play();

		        //4.Wait for it to finish playing
		        while (adSource.isPlaying)
		        {
		            yield return null;
		        }

		        //5. Go back to #2 and play the next audio in the adClips array
		    }
	}

	void Awake() {
		coroutine = playAudioSequentially();
		StartCoroutine(coroutine);
        DontDestroyOnLoad(transform.gameObject);
     }	
}

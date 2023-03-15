
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPrefab : MonoBehaviour
{
    public Object myPrefab;
    int x = -4;
	float y = 0.5F;
	

	// Start is called before the first frame update
    void Start()
    {
	    for(int z=0; z<10; z++){
			Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

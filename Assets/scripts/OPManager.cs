using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OPManager : MonoBehaviour {
    [SerializeField]
    GameObject[] OPList;
    Vector3 auxPosition;

	// Use this for initialization
	void Start () {
		
	}
	
    public void NextOP()
    {
        GameObject[] AuxList = new GameObject[4];
        auxPosition = OPList[0].transform.position;
        OPList[0].transform.position = OPList[1].transform.position;
        OPList[1].transform.position = auxPosition;
        for (int i=0; i<4; i++)
            AuxList[i] = OPList[(i + 1)%4];
        OPList = AuxList;
    }

    public void PreviousOP()
    {
        GameObject[] AuxList = new GameObject[4];
        auxPosition = OPList[0].transform.position;
        OPList[0].transform.position = OPList[3].transform.position;
        OPList[3].transform.position = auxPosition;
        for (int i = 0; i < 4; i++)
            AuxList[i] = OPList[(3 + i) % 4];
        OPList = AuxList;
    }

}

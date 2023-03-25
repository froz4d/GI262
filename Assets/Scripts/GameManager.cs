using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject staffPrefab;
    [SerializeField] private GameObject staffParent;

    // Start is called before the first frame update
    void Start()
    {
        GenerateCandidat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateCandidat()
    {
        for (var i = 0; i < 20; i++)
        {
            GameObject staffObj = Instantiate(staffPrefab, staffParent.transform);
            Staff s = staffObj.GetComponent<Staff>();

            s.InnitCharID(i);
            s.ChangeCharSkin();
        }
    }


}

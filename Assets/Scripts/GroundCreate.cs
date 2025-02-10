using UnityEngine;

public class GroundCreate : MonoBehaviour
{
    public GameObject box;
    public Vector3 createPos;
    [SerializeField]
    int mapSize = 12;
    float boxWid = 2f;//오브젝트 박스 길이 만큼 떨구기용
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < mapSize; i++)
        {
            for (int j = 0; j < mapSize; j++)
            {
                Instantiate(box, new Vector3(createPos.x + (i * boxWid), 0, createPos.z + (j * boxWid)), box.transform.rotation);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

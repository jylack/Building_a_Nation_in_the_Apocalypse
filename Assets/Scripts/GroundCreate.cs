using UnityEngine;

public class GroundCreate : MonoBehaviour
{
    public GameObject box;
    public Vector3 createPos;

    [SerializeField]
    int mapSize = 12;
    float boxWidth = 2f;//������Ʈ �ڽ� ���� ��ŭ �������
    
    void Start()
    {
        
        for (int i = 0; i < mapSize; i++)
        {
            for (int j = 0; j < mapSize; j++)
            {
                Instantiate(box, new Vector3(createPos.x + (i * boxWidth), 0, createPos.z + (j * boxWidth)), box.transform.rotation,transform);
            }
        }
    }

    
    void Update()
    {

    }
}

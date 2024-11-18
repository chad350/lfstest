using UnityEngine;

public class SetTagManager : MonoBehaviour
{
    public bool enableTag = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ()
        {
            SetRandomActiveState();
        }
    }

    private void SetRandomActiveState()
    {
        bool randomState = Random.value > 0.5f;
        gameObject.SetActive(randomState);
    }
}

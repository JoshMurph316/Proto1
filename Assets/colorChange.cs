using UnityEngine;

public class colorChange : MonoBehaviour
{
    public Material[] materials;
    public bool invisible;

    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(invisible)
        {
            rend.sharedMaterial = materials[1];
        } else
        {
            rend.sharedMaterial = materials[0];
        }
    }
}

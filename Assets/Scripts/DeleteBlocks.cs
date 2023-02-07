using UnityEngine;

public class DeleteBlocks : MonoBehaviour
{
    private void Start()
    {
        GameObject[] blocks = GameObject.FindGameObjectsWithTag("DeleteBlock");

        foreach (var block in blocks)
        {
            Destroy(block);
        }
    }
}

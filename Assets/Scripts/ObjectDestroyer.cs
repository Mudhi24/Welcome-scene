using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public GameObject[] array1;
    public GameObject[] array2;
    public GameObject objectToActivate1;
    public GameObject objectToActivate2;

    public void DestroyArray(GameObject[] arrayToDestroy)
    {
        foreach (GameObject obj in arrayToDestroy)
        {
            Destroy(obj);
        }
    }

    public void DestroyArray1()
    {
        DestroyArray(array1);        
        objectToActivate1.SetActive(true);

    }

    public void DestroyArray2()
    {
        DestroyArray(array2);
        objectToActivate2.SetActive(true);
    }

}

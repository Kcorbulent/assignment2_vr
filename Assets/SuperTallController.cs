using UnityEngine;

public class SuperTallController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public int ingredient = 0;
    public Transform superTallSandwich;
    public void nextIngredient()
    {
        ingredient = ingredient + 1;
        if (ingredient <= 15)
        {
            transform.GetChild(ingredient).gameObject.transform.SetPositionAndRotation(new Vector3(transform.GetChild(ingredient).gameObject.transform.position.x + 1000, transform.GetChild(ingredient).gameObject.transform.position.y, transform.GetChild(ingredient).gameObject.transform.position.z), transform.GetChild(ingredient).gameObject.transform.rotation);
            transform.GetChild(ingredient).gameObject.SetActive(true);
        }
        if (ingredient >= 15)
        {
            superTallSandwich.GetChild(0).gameObject.SetActive(true);
            superTallSandwich.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            superTallSandwich.GetComponent<BoxCollider>().isTrigger = false;
        }
    }
}

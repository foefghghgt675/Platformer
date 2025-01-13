using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
<<<<<<< Updated upstream
    public SpriteRenderer body;
    public SpriteRenderer hand;

    private Camera cam;

=======
    private Camera cam;
    // Start is called before the first frame update
>>>>>>> Stashed changes
    void Start()
    {
        cam = Camera.main;
    }

<<<<<<< Updated upstream

=======
    // Update is called once per frame
>>>>>>> Stashed changes
    void Update()
    {
        var mousePos = Input.mousePosition;
        var worldPos = cam.ScreenToWorldPoint(mousePos);
        worldPos.z = 0;
<<<<<<< Updated upstream
        var direction = worldPos - transform.position;
        direction.Normalize();

        if (direction.x < 0)
        {
            body.flipX = true;
            hand.flipY = true;
        }
        else
        {
            body.flipX = false;
            hand.flipY = false;
        }

        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
=======
        var direction = worldPos -transform.position;
        direction.Normalize();
        var angle = Mathf.Atan2(direction.y, direction.x)* Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,angle);
>>>>>>> Stashed changes
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [SerializeField] Canvas mainCanvas;

    public void ChangeDescriptionField(GameObject lastComponentHit) {
        DescriptionController descriptionComponent = mainCanvas.GetComponentInChildren<DescriptionController>();
        if (lastComponentHit != null) {
            mainCanvas.GetComponent<MainCanvasController>().ActivateDescriptionField();
            ComponentSpecs component = lastComponentHit.GetComponent<ComponentSpecs>();
            descriptionComponent.ChangeText($"{component.componentName}:\n{component.description}");
        } else {
            mainCanvas.GetComponent<MainCanvasController>().DeactivateDescriptionField();
        }
    }

}

using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.EventSystems;

public class HapticFeedbackOnUI : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler,IPointerClickHandler
{
    //����� ��Ʈ�ѷ�
    public XRBaseController controller; 
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("����");
        TriggerHapticFeddBack(0.2f, 1.0f);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        TriggerHapticFeddBack(0.1f, 0.5f);
        //throw new System.NotImplementedException();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    //amplitude - ����  duration - ���ӽð�
    private void TriggerHapticFeddBack(float amplitude, float duration)
    {
        if (controller != null) 
        { 
            //Haptic�� ����ϰ� ���ִ� �Լ�
            controller.SendHapticImpulse(amplitude, duration);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class LOCALE_SELECTOR : MonoBehaviour
{
    private bool active = false;
    public void ChangeLocale(int localeID)
    {

        if (active == true) // �p�G�w�g�ҰʡA�A���I�s�ɴN��������(return)
            return;
        StartCoroutine(SetLocale(localeID));
    }


    IEnumerator SetLocale(int  _localeID)
    {
        active = true;

        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localeID]; //�N�w�]locale�]�w�����w��aid�Atw 0 eng 1

        active = false;
    }
}

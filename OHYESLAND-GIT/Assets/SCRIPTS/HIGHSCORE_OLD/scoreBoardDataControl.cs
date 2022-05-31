using UnityEngine;
using System.Collections;
using System;  //Serializable
using System.Runtime.Serialization.Formatters.Binary; //BinaryFormatter
using System.IO;  //FileStream

public class ScoreBoardDataControl : MonoBehaviour
{
    //Singleton Pattern�A�i�ϥ���{���I�sScoreBoardDataControl.instance���o�Ӫ���
    public static ScoreBoardDataControl instance;

    //����x�s���Ƹ�ƪ�����(ScoreData�w�q�b�U��)
    private ScoreData data;

    //�n��ܪ��W���ƶq(3��ܥu��ܫe�T�W)     
    private const int Places = 3;

    void Awake()
    {
        //Singleton Pattern�A�u��֦��@��ScoreBoardDataControl����
        if (instance == null)
        {

            //�ഫ�����ɤ��n������Game Object
            DontDestroyOnLoad(gameObject);

            //���J�Ʀ�]���
            LoadData();

            //��instance�]�n�A�H�Ѩ�L�a��HScoreBoardDataControl.instance���o����
            instance = this;

        }
        else if (instance != this)
        {

            //�ĤG���i�J�}�l�e���A��s��ScoreBoardDataControl�R��
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        float theScore = STATIC_SCORE.allScore;
        int theScoreInt = Convert.ToInt32(theScore);
        ScoreBoardDataControl.instance.NewScore(theScoreInt,theScoreInt);
    }
    void LoadData()
    {
        //�p�G�ɮצs�b(��ܤ��O�Ĥ@���}�ҹC��)
        if (File.Exists(Application.persistentDataPath + "/scoreInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/scoreInfo.dat", FileMode.Open);

            //��˸m�����G�i���ɮפϧǦC�ơA�s�Jdata�ܼƤ�
            data = (ScoreData)bf.Deserialize(file);
            file.Close();
        }
        else
        {     //�p�G�ɮפ��s�b(�Ĥ@���}�ҹC��)
            InitData(); //��l�Ƹ��
            SaveData(); //�x�J�˸m
        }
    }

    void InitData()
    {
        //��l��data�Bdata���}�C
        data = new ScoreData();
        data.scores = new int[Places];
        data.playerTypes = new int[Places];

        for (int i = 0; i < Places; i++)
        {
            data.scores[i] = 0;
            data.playerTypes[i] = -1;
        }
    }

    void SaveData()
    {
        BinaryFormatter bf = new BinaryFormatter();

        //�s�W�ɮ�
        FileStream file = File.Create(Application.persistentDataPath + "/scoreInfo.dat");

        //�ǦC�ơA�s�J�˸m
        bf.Serialize(file, data);
        file.Close();
    }

    public void NewScore(int playerType, int score)
    {
        //�P�_�����Ư�Ʀb�ĴX�W
        int place = Places - 1;

        while (place >= 0 && score > data.scores[place])
        {
            place--;
        }

        place++;

        //�L�k�i�J�Ʀ�]
        if (place >= Places)
            return;

        //�⦹���Ƥ��᪺�ƦW�V�ᮿ�@�W
        for (int i = Places - 2; i >= place; i--)
        {
            data.scores[i + 1] = data.scores[i];
            data.playerTypes[i + 1] = data.playerTypes[i];
        }

        //��s�W��
        data.scores[place] = score;
        data.playerTypes[place] = playerType;

        //�s�J�˸m
        SaveData();
    }

    //���oplace�W��������
    public int GetScore(int place)
    {
        return data.scores[place];
    }


    //���oplace�W���ҨϥΪ�����
    public int GetPlayerType(int place)
    {
        return data.playerTypes[place];
    }
}

[Serializable]  //�i�ǦC�ƪ����O
class ScoreData
{
    public int[] scores; //�x�s�e�T�W������
    public int[] playerTypes; //�x�s�e�T�W�ϥΪ�����
}
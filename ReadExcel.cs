using UnityEngine;
using System.Collections.Generic;

public class ReadExcel : MonoBehaviour
{
    public TextAsset txt;
    public string[,] Sentence;
    int lineSize, rowSize;
    public void readEx(){

        string currentText = txt.text.Substring(0, txt.text.Length - 1);
        string[] line = currentText.Split('\n');
        lineSize = line.Length;
        rowSize = line[0].Split('\t').Length;
        Sentence = new string[lineSize, rowSize];

        for (int i = 0; i < lineSize; i++)
        {
            string[] row = line[i].Split('\t');
            for (int j = 0; j < rowSize; j++)
            {
                Sentence[i, j] = row[j];
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace splitting_a_string_into_a_two_dimensional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // номер комірки для зміни значень
            int itemNumber = 2, // Номер комірки 
                itemArray = 1; // Номер параметру комірки

            // два текстові рядки
            string str = "1: 10\n2: 20\n3: 30";
            string str2 = "";
            // масив для запису першого рядка
            string[] strArray1 = str.Split('\n');
            // запис у окремий рядок потрібної комірки
            for (int i = 0; i < strArray1.Length; i++)
            {
                // перевірка досягнутості потрібної комірки
                if (i == itemNumber)
                {
                    // запис значень потрібної комірки у тексовий рядок
                    str2 = strArray1[itemNumber];
                    // зупинка циклу
                    break;
                }
                else
                    // пропущення всіх інших комірок
                    continue;
            }
            // запис другого рядка у окремий масив
            string[] strArray2 = str2.Split(' ');
            // конвертація вказаної комірки в числовий формат, зміна та запис у змінну числового типу
            int digital = Convert.ToInt32(strArray2[itemArray]) + 10;
            // оновлення вказаної комірки
            strArray2[itemArray] = digital.ToString();
            // очищення рядку
            str2 = "";
            // цикл який проходить по всій довжині першого масиву
            for (int i = 0; i < strArray1.GetLength(0); i++)
            {
                // перевірка досягнутості потрібної комірки
                if (i != itemNumber)
                {
                    continue;
                }
                else
                {
                    // цикл який проходить по всій довжині другого масиву
                    for (int j = 0; j < strArray2.GetLength(0); j++)
                    {
                        // перезапис потрібної комірки в першому масиві зміненою коміркою другого масиву
                        if (j == 0)
                            strArray1[i] = strArray2[j];
                        else
                            strArray1[i] += $" {strArray2[j]}";
                    }
                }
            }
            foreach (string str3 in strArray1)
                Console.WriteLine(str3);
        }
    }
}

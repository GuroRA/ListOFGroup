using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOFGroup
{

    internal class Program
    {

        static string GetTextFile(Dictionary<byte, string> students)
        {

            Random rnd = new Random();

            string text = string.Empty;
            byte[] randomNumbers = new byte[students.Count];
            for (int number = 0; number < randomNumbers.Length; number++)
            {
                randomNumbers[number] = (byte)number;
            }
            for (int i = randomNumbers.Length-1; i > 0; i--)
            {
                int randomIndex = rnd.Next(0, i + 1);
                byte temp = randomNumbers[i];
                randomNumbers[i] = randomNumbers[randomIndex];
                randomNumbers[randomIndex] = temp;
            }
            for (byte i = 1; i <= students.Count; i++)
            {
                text += $"{students[i]} {randomNumbers[i-1]+1}\n";
            }

            string textStudents = text;

            File.AppendAllText("students.txt", text);

            return textStudents;
        }

        static void Main(string[] args)
        {
            Dictionary<byte, string> students = new Dictionary<byte, string>()
            {
                {1, "Берсенёв Семён" },
                {2, "Боронин НИкита" },
                {3, "Валетдинов Денис" },
                {4, "Верхотурова Арина" },
                {5, "Гомза Арина" },
                {6, "Джумакулыев Алиджан" },
                {7, "Закиров Айназ" },
                {8, "Калимулин Айназ" },
                {9, "Квятковский Всеволод" },
                {10, "Кузьмина Анастасия" },
                {11, "Меркулова Софья" },
                {12, "Новикова Анастасия" },
                {13, "Осипов Семён" },
                {14, "Парышева Анна" },
                {15, "Прокофьева Софья" },
                {16, "Рахматулина Алия" },
                {17, "Садриев Салават" },
                {18, "Тарышкин Александр" },
                {19, "Фазылов Раис" },
                {20, "Харламова Анна" },
                {21, "Хисматуллин Адель" },
                {22, "Целоуссов Игорь" },
                {23, "Шамкина Карина" },
                {24, "Юмагулова Анна" },
                {25, "Балабанова Арина" },
                {26, "Валеев Сергей" },
                {27, "Габов Алексей" },
                {28, "Гараева Диляра" },
                {29, "Гафуров Камиль" },
                {30, "Гиндулин Марат" },
                {31, "Гуро РУслан" },
                {32, "Дорожан Андрей" },
                {33, "Каштанов Радмир" },
                {34, "Лисюткина Руслана" },
                {35, "Маркелов Михаил" },
                {36, "Мингалёв Андрей" },
                {37, "Минушина Алия" },
                {38, "Мулагалиев Амир" },
                {39, "Назарова Дарья" },
                {40, "Новоселова Ульяна" },
                {41, "Пигуляк Роман" },
                {42, "Пушкина Анджела" },
                {43, "Сабирова Далия" },
                {44, "Спиридонова Весна" },
                {45, "Халикова Данна" },
                {46, "Хубайбулина Зарина" },
                {47, "Шайтутдинова Алина" },
                {48, "Шакиров Эмиль" },
                {49, "Шамсутдинов Нурсултан" },
  

            };
            GetTextFile(students);
            Console.WriteLine("Файл создан в bin/Debug/students.txt");
            Console.ReadKey();
        }
    }
}
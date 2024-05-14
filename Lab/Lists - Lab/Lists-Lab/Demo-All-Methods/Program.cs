using System;
using System.Linq;
using System.Collections.Generic;

namespace Demo_All_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Дефиниране на списък/лист и въвеждане от конзолата
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //Всички методи
            //Добавяне на конкретен елемент
            numbers.Add(n);
            //Изтриване на конкретен елемент
            numbers.Remove(1);
            //Изтрива елемент на даден от нас индекс
            numbers.RemoveAt(1);
            //Сортира елемнтите на лист от най - малко до най - голямо (ако е string по азбучен ред)
            numbers.Sort();
            //Обръща елементите в листа (първият става последен и т.н.)
            numbers.Reverse();
            //Добавя елемент на даден индех
            numbers.Insert(1, n);
            //Намира индекса на даден елемент
            numbers.IndexOf(n);
            //Извежда броя на елементите в листа == .Length
            numbers.Count();
            //Проверява дали в листа се съдържа даден елемент и извежда true или false
            numbers.Contains(n);
            //Изкарва всички четни или нечетни елементи
            List<int> oddNumbers = numbers.Where(x => x % 2 != 0).ToList();
            List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
            //Изкарва всички числа по големи от дадено число
            List<int> biggerThan = numbers.Where(x => x > 4).ToList();
            //Сортира листа от най - малко към най - голямо (възходящ)
            List<int> orderByAscending = numbers.OrderBy(x => x).ToList();
            //Сортира листа от най - голямо към най - малко (низходящ)
            List<int> orderByDescending = numbers.OrderByDescending(x => x).ToList();
            //Проверява дали някой елемент който съвпада с някакво число от листа 
            bool any = numbers.Any(x => x == n);
            //Проверява дали всички елемнти от листа са по големи от дадено число
            bool all = numbers.All(x => x > n);
            //Ако има няколко еднакви елемента в листа този методи извежда на кой индекс се намира последният
            int lastIndexOf = numbers.LastIndexOf(n);
            //Слепя нов лист до вече съдадения лист или просто добавя по голям обхват от данни
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.AddRange(integers);
            //Изчиства целия лист
            numbers.Clear();
            //Намира най - малкото и най - голямото число в листа
            int minValue = numbers.Min();
            int maxValue = numbers.Max();
            //Намира средното число в лисра
            List<int> newList = new List<int> { 1, 2, 3, 4, 5 };
            double average = newList.Average();
            //Пресмята сумата от всички елементи в листа
            double sum = numbers.Sum();
            //Пропуска първите пет елемента
            List<int> skip = numbers.Skip(5).ToList();
            //Взима само първите два елемента
            List<int> take = numbers.Take(2).ToList();
        }
    }
}

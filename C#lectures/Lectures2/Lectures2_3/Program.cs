﻿/* (Найти индекс запрашиваемого числа) 
Имеется одномерный массив array из п элементов, требуется найти элемент массива, равный find(введеный пользователем)
1.	Установить счетчик index в позицию О
2.	Если array [index] = find, алгоритм завершил работу успешно.
3.	Увеличить index на 1
4.	Если index < п, то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно.
*/

//Свойство Length это длина текста (количество символов).


int[] array = {1, 12, 31, 4, 18, 15, 1, 17, 18};
int n = array.Length;
Console.WriteLine(n);
int find = 18;
int index = 0;
while (index < n )
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; //прерви 
    }
    index ++;
}
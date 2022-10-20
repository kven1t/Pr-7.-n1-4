using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

double x = 0, y = 0, z = 0, w = 0;
Console.WriteLine("Введите значение х:");

try
{
    x = Convert.ToDouble(Console.ReadLine());
    y = Math.Sqrt((x + 3) / (x - 3)); // квадратный корень
}
catch (Exception e) // оператор, для исключений
{
    Console.WriteLine(e.Message); //описывает исключение
}

Console.WriteLine("Введите значение z:");
z = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение w:");
w = Convert.ToDouble(Console.ReadLine());

y = Math.Sqrt(x); //квадратный корень
Console.WriteLine("Результат Sqrt: {0}", y); 

y = Math.Abs(x); //модуль
Console.WriteLine("Результат Abs: {0}", y);

y = Math.Acos(x); //арккосинус
Console.WriteLine("Результат Acos: {0}", y);

y = Math.Acosh(x); //гиперболический косинус
Console.WriteLine("Результат Acosh: {0}", y);

y = Math.Asin(x); //арксинус
Console.WriteLine("Результат Asin: {0}", y);

y = Math.Asinh(x); //возвращает угол, гиперболический синуса
Console.WriteLine("Результат Asinh: {0}", y);

y = Math.Atan(x); //арктангинс
Console.WriteLine("Результат Atan: {0}", y);

y = Math.Atan2(x, z); //возвращает угол, тангенс которого равен отношению двух указанных чисел 
Console.WriteLine("Результат Atan2: {0} ({1}, {2})", y, x, z);

y = Math.Atanh(x); //Возвращает угол, гиперболического тангенса
Console.WriteLine("Результат Atanh: {0}", y);

long t = 0;
t = Math.BigMul((int)x, (int)z); //вычисление наибольшего из двух указанных чисел
Console.WriteLine("Результат BigMul: {0} ({1} {2})", t, (int)x, (int)z);

y = Math.BitDecrement(x); //ближайшее самое маленькое значение, которое меньше, чем x
Console.WriteLine("Результат BitDecrement: {0} ({1})", y, x); 

y = Math.BitIncrement(x); //ближайшее самое большое значение, превышающее x
Console.WriteLine("Результат BitIncrement: {0} ({1})", y, x);

y = Math.Cbrt(x); //кубический корень
Console.WriteLine("Результат Cbrt: {0} ({1})", y, x);

y = Math.Ceiling(x); //наименьшее целое число, которое больше или равно х
Console.WriteLine("Результат Ceiling: {0} ({1})", y, x);

byte b = 0;
b = Math.Clamp((byte)x, (byte)z, (byte)w); //зажимает число между минимальным и максимальным значением
Console.WriteLine("Результат Clamp: {0} ({1} {2} {3})", b, (byte)x, (byte)z, (byte)w);

y = Math.CopySign(x, z); //выделение наименьшего значения из указанных переменных
Console.WriteLine("Результат CopySign: {0} ({1} {2})", y, x, z);

y = Math.Cos(x); //косинус
Console.WriteLine("Результат Cos: {0} ({1})", y, x);

y = Math.Cosh(x); //гиперболический косинус
Console.WriteLine("Результат Cosh {0} ({1})", y, x);

int output = 0;
y = Math.DivRem((int)x, (int)z, out output); //вычисляет частное двух чисел и возвращает остаток в выходном параметре
Console.WriteLine("Результат DivRem {0} ({1} {2}) result = {3}", y, x, z, output);

y = Math.E; // число е
Console.WriteLine("Результат E {0}", y);

y = Math.Exp(x); //возвращает e, возведенное в указанную степень
Console.WriteLine("Результат Exp {0} ({1})", y, x);

y = Math.Floor(x); //возвращает наибольшее целое число, которое меньше или равно указанному числу
Console.WriteLine("Результат Exp {0} ({1})", y, x);

y = Math.FusedMultiplyAdd(x, z, w); //возвращает значение (x * z) + w, округленное в рамках одной операции.
Console.WriteLine("Результат FusedMultiplyAdd(x*z+w) {0} ({1} {2} {3} )", y, x, z, w);

y = Math.IEEERemainder(x, z);  //возвращает остаток от деления одного указанного числа на другое
Console.WriteLine("Результат IEEERemainder {0} ({1} {2})", y, x, z);

y = Math.ILogB(x);  //логарифм с основанием 2 
Console.WriteLine("Результат ILogB {0} ({1})", y, x);

y = Math.Log(x); //логарифм 
Console.WriteLine("Результат Log {0} ({1})", y, x);

y = Math.Log10(x); //логарифм с основанием 10
Console.WriteLine("Результат Log10 {0} ({1})", y, x);

y = Math.Log2(x); //логарифм с основанием 2 
Console.WriteLine("Результат Log2 {0} ({1})", y, x);

y = Math.Max(x, z); //выбор максимального из двух указанных чисел
Console.WriteLine("Результат Max {0} ({1} {2})", y, x, z);

y = Math.MaxMagnitude(x, z); //возвращает большую величину из двух чисел двойной точности с плавающей запятой
Console.WriteLine("Результат MaxMagnitude {0} ({1} {2})", y, x, z);

y = Math.Min(x, z); //выбор минимального из двух указанных чисел
Console.WriteLine("Результат Min {0} ({1} {2})", y, x, z);

y = Math.MinMagnitude(x, z); //возвращает меньшую величину из двух чисел двойной точности с плавающей запятой.
Console.WriteLine("Результат MinMagnitude {0} ({1} {2})", y, x, z);

y = Math.PI; //число P
Console.WriteLine("Результат PI {0} ", y);

y = Math.Pow(x, z); //возведение в степень z
Console.WriteLine("Результат Pow {0} ({1} {2})", y, x, z);

y = Math.ReciprocalEstimate(x); //возвращает оценку взаимности указанного числа.
Console.WriteLine("Результат ReciprocalEstimate {0} ({1})", y, x);

y = Math.ReciprocalSqrtEstimate(x); //возвращает оценку обратного квадратного корня указанного числа.
Console.WriteLine("Результат ReciprocalSqrtEstimate {0} ({1})", y, x);

y = Math.Round(x); //округление введенного значения
Console.WriteLine("Результат Round {0} ({1})", y, x);

y = Math.ScaleB(x, (int)z); //возвращает значение x * 2^z
Console.WriteLine("Результат ScaleB (x*2^z) {0} ({1} {2})", y, x, (int)z);

y = Math.Sign(x); //возвращает целое число, указывающее знак числа.
Console.WriteLine("Результат Sign {0} ({1})", y, x);

y = Math.Sin(x); //синус
Console.WriteLine("Результат Sin {0} ({1})", y, x);

var d = Math.SinCos(x); //объявление переменной d; возвращение синус и косину указанного угла
Console.WriteLine("Результат SinCos {0} ({1})", y, d.ToString());

y = Math.Sinh(x); //гиперболический синус
Console.WriteLine("Результат Sinh {0} ({1})", y, x);

y = Math.Tan(x); //тангенс
Console.WriteLine("Результат Tan {0} ({1})", y, x);

y = Math.Tanh(x); //гиперболический тангенс
Console.WriteLine("Результат Tanh {0} ({1})", y, x);

y = Math.Tau; //представляет число радианов в полном обороте
Console.WriteLine("Результат Tau {0}", y);

y = Math.Truncate(x);  //вычисляет целую часть числа
Console.WriteLine("Результат Truncate {0} ({1})", y, x);
﻿using Calculadora.Services;

CalculadoraImp calc = new CalculadoraImp();

int num1 = 5;
int num2 = 5;

Console.WriteLine($"{num1} + {num2} = {calc.Somar(num1,num2)}");
# StringReduction
Сокращение строки
сокращение ее последоватьности, принимает она как параметр строку с исходной последовательность и возвращает строку с скоращенной.

На вход приходит: ”AAABBBBCCCAB”, то тогда на выходе должна быть строка: ”A3B4C3AB”.
То есть если в исходной строке буква встречается больше одного раза, то серию таких букв надо в выходной строке преобразовать в “A{X}”, где {X} длина последовательности одинаковых букв.
Если в строке встречается что-то кроме больших латинских букв, то функция должна вернуть ошибку

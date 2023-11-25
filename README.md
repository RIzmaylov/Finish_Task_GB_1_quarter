# Итоговая контрольная работа по основному блоку

## Описание условия задачи:
    Написать программу, которая из имеющегося массива строк формирует *новый* массив из строк, длина которых **меньше, либо равна 3** символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении **не рекомендуется пользоваться коллекциями**, лучше обойтись исключительно массивами.

### Порядок действий:
1. Составить блок-схему алгоритма решения поставленной задачи
2. Написать код

### Описание алгоритма:
* В начале у пользователя запрашивается количество элементов массива, которые в последствии им будут вводиться.
* Создается пустой массив и в этот массив в цикле записываются введенные с клавиатуры пользователем строки - элементы массива. В этом же цикле проверяется длина введенной строки. Если она меньше или равна 3 символам, то увеличиваем счетчик, который в последствии станет количеством элементов результирующего массива.
* Создаем результирующий массив и в цикле, проходясь по элементам исходного массива с условием, что строка меньше, либо равна 3 символам, заполняем его.
* Выводим результирующий массив на экран.
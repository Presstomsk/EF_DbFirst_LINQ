# EF_DbFirst_LINQ

***Тестовая база данных MySQL по ссылке https://github.com/Presstomsk/EF_DbFirst_LINQ/tree/master/EF_DbFirst_LINQ/Db_Information***

***Для работы с существующей БД нам надо добавить два пакета:
![изображение](https://user-images.githubusercontent.com/77540319/154790010-1e4b7d69-0d2e-40e4-9f79-05ca22674ac5.png)***

***Первый представляет функциональность Entity Framework для работы с MySQL.
Второй необходим для создания классов по базе данных, то есть reverse engineering.***

***Для реверса базы данных и создания по ней классов C# в Visual Studio в окне Package Manager Console выполняется следующая команда:***

***■ Scaffold-DbContext "строка подключения" провайдер_бд***

# Задание 1

Проведите нормализацию базу данных «Страны».
В результате нормализации у вас должна появиться многотабличная база данных «Страны». 
Добавьте новую информацию:

■ Количество жителей в столице;

■ Названия крупных городов страны с количеством
жителей в каждом городе.

# Задание 2

Реализуйте следующие LINQ запросы для базы данных «Страны»:

■ Отобразить всю информацию о странах;

■ Отобразить название стран;

■ Отобразить название столиц;

■ Отобразить название крупных городов конкретной
страны;

■ Отобразить название столиц с количеством жителей
больше пяти миллионов;

■ Отобразить название всех европейских стран;

■ Отобразить название стран с площадью большей
конкретного числа.

# Задание 3

Реализуйте следующие LINQ запросы для базы данных «Страны»:

■ Отобразить все столицы, у которых в названии есть
буквы a, p;

■ Отобразить название стран, у которых площадь находится в указанном диапазоне;

■ Отобразить название стран, у которых количество
жителей больше указанного числа.

# Задание 4

Реализуйте следующие LINQ запросы для базы данных «Страны»:

■ Показать топ-5 стран по площади;

■ Показать топ-5 столиц по количеству жителей;

■ Показать страну с самой большой площадью;

■ Показать столицу с самым большим количеством
жителей;

■ Показать страну с самой маленькой площадью в Европе;

■ Показать среднюю площадь стран в Европе;

■ Показать топ-3 городов по количеству жителей для
конкретной страны;

■ Показать общее количество стран;

■ Показать часть света с максимальным количеством
стран;

■ Показать количество стран в каждой части света.

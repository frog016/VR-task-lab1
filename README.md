# VR-task-lab1

Отчет по лабораторной работе #1 выполнил:
- Михалев Никита Олегович РИ-300023
- Отметка о выполнении заданий:

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * | 60 |
| Задание 2 | * | 20 |
| Задание 3 | * | 20 |

Работу проверили:

## Цель работы
Ознакомиться с основными функциями Unity и взаимодействием с объектами внутри редактора.

## Задание 1
### В разделе «ход работы» пошагово выполнить каждый пункт с описанием и примера реализации задач по теме лабораторной работы.

Ход работы:

1. Создать новый проект из шаблона 3D – Core;
![1](https://user-images.githubusercontent.com/78908105/190860656-a082b367-d715-4e15-b327-a5656c17ed31.png)

2. Проверить, что настроена интеграция редактора Unity и Visual Studio Code;
![2](https://user-images.githubusercontent.com/78908105/190860681-17c3b53d-de32-4b8e-bce3-6d9caabf3bdc.png)

3. Создать объект Plane;
![3](https://user-images.githubusercontent.com/78908105/190860685-280194e9-9b06-45ed-8a3b-5047d683177c.png)

4. Создать объект Cube;
![4](https://user-images.githubusercontent.com/78908105/190860688-32240c91-73b5-4a30-bce9-1c9971e6fa48.png)

5. Создать объект Sphere;
![5](https://user-images.githubusercontent.com/78908105/190860693-0799e17c-69ea-4a57-9eda-be2385785dd2.png)

6. Установить компонент Sphere Collider для объекта Sphere;
7. Настроить Sphere Collider в роли триггера;  
![6-7](https://user-images.githubusercontent.com/78908105/190860695-fb36e117-ba9a-49cd-bba6-fc3a151f876a.png)

8. Объект куб перекрасить в красный цвет;
![8](https://user-images.githubusercontent.com/78908105/190860700-65c28acc-afb1-492a-a745-1e24f6b84c83.png)

9. Добавить кубу симуляцию физики, при это куб не должен проваливаться под Plane;
![9](https://user-images.githubusercontent.com/78908105/190860702-76de8447-d8fe-4a5e-9382-c467980d96e7.png)

10. Написать скрипт, который будет выводить в консоль сообщение о том, что объект Sphere столкнулся с объектом Cube;
![10 1](https://user-images.githubusercontent.com/78908105/190860705-1a946d4d-b631-4ca4-acfa-cfb205ef43ce.png)
![10 2](https://user-images.githubusercontent.com/78908105/190860709-7f315a4e-7d9f-4dc8-a514-83e22e8d1aad.png)

11. При столкновении Cube должен менять свой цвет на зелёный, а при завершении столкновения обратно на красный.
![11 1](https://user-images.githubusercontent.com/78908105/190860711-d02446be-aa93-4700-a07c-53253c5a97ed.png)
![11 2](https://user-images.githubusercontent.com/78908105/190860712-b9ca4284-c30c-4e79-802a-7a60bca8a466.png)
![11 3](https://user-images.githubusercontent.com/78908105/190860713-a6744ed5-37e2-4a03-ba70-32cf519eee60.png)

## Задание 2
### Продемонстрируйте на сцене в Unity следующее:

- Что произойдёт с координатами объекта, если он перестанет быть дочерним?
- Создайте три различных примера работы компонента RigidBody?

### Ответы:

1. Когда объект перестает быть дочерним, его координаты переходят из локальных родительских в глобальные.
![22 1](https://user-images.githubusercontent.com/78908105/190860875-ae228bb3-9d0f-4ff4-b16f-ed99ef17715a.png)
![22 2](https://user-images.githubusercontent.com/78908105/190860877-74de2881-22fc-4cd4-b9df-fde25c3982d9.png)

2. Примеры разных rigidbody: 

    1. Обычный rigidbody с гравитацией. Такой объект сталкивается с остальными и перемещается под воздействием гравитации.
    ![22 3 2](https://user-images.githubusercontent.com/78908105/190861274-b597b2e0-6ed0-4ec2-8793-37637d7f19c1.png)  

    2. Rigidbody с выключенной гравитацией. Он ведет себя так же, как и прошлый, но на него не действует гравитация.
    ![22 3 3](https://user-images.githubusercontent.com/78908105/190861315-f5ec672e-0d23-4401-a12a-1708fdc7d2ca.png)  

    3. Kinematic rigidbody. Это тело не сталкивается с другими rigidbody.  
    ![22 3 4](https://user-images.githubusercontent.com/78908105/190861372-d0e0acbd-6604-45a3-9792-c0f9e6cd389d.png)  

* Все 3 тела слева направо соответсвенно.
![22 3 1](https://user-images.githubusercontent.com/78908105/190861391-28aecb41-32c8-48b4-912a-6bb55b6d5c58.png)

## Задание 3
### Реализуйте на сцене генерацию n кубиков. Число n вводится пользователем после старта сцены.

* При окончании ввода в поле числа кубов в запущенной сцене начинается их генерация с определенной задержкой. Выставить задержку и отступ между ними можно в инспекторе в скрипте у объекта **CubeGenerator**.
![33](https://user-images.githubusercontent.com/78908105/190861599-9279fc1c-adbb-4c91-aae0-2c07ddcb69b2.png)

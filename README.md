# showcase
<b>ПОСТАНОВКА ЗАДАЧИ</b>

Для N-го количества проектов требуется создать шаблонный функционал по выбору объектов и выводу данных о них. Объектами могут являться игровые персонажи, предметы для инвентаря, режимы игры, локации и так далее. Шаблонный функционал должен представлять собой набор базовых классов и абстракций свозможностью дальнейшего переиспользования и наследования. В шаблоне должно быть как минимум 2 примера реализации.

<b>ДАТА</b>

При проектировании базовых данных необходимо активно использовать все принципы SOLID и ООП. У любой даты должен быть единственный базовый родитель. Все данные объектов не должны находиться в оперативной памяти до момента обращения к ним пользователем. Обязательно наличие контейнера, где будет храниться текущая выбранная дата.

<b>INPUT</b>

Input должен быть кроссплатформенным, при этом нельзя использовать Input System. Дату можно переключать различными способами как мобильными, так и десктоп. При этом сама дата и контейнеры не имеют связи с Input и не знают о его текущей реализации.

<b>ОТОБРАЖЕНИЯ НА ЭКРАНЕ</b>

Можно использовать Unity примитивы и стоковые изображения / модели. Запрещено размещать на Unity сцене сразу все окна пользовательского интерфейса, они должны подгружаться в память по мере обращения к ним пользователя.

<b>ПРИМЕРЫ В ШАБЛОНЕ</b>

- Пример с выбором персонажей, у которых есть Имя, Уровень, изображение в виде 2D аватарки, отображение в виде 3D объекта. Пользователь может выбирать в интерфейсе текущего персонажа как через Canvas, так и через клавиатуру.
- Пример с выбором текущей локации для игры. Пользователь выбирает в сцене меню нужную локацию и запускает ее загрузку. Каждая локация содержит Название, описание локации, изображение в виде 2D и id сцены.

<b>ТРЕБОВАНИЯ К ВЫПОЛНЕНИЮ ТЕСТОВОГО ЗАДАНИЯ</b>

- В коде задания должен быть единый Code Style (C# Code Convention). 
- Запрещено использование сторонних решений в виде Zenject, UniRX, ECS и так далее. 
- Запрещено использование паттерна "Одиночка", а также множественные поиски с применением MonoBehaviour.














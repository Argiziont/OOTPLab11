Develop a technical task. Show the decomposition of the task, where some of the tasks should be implemented using generative patterns:
- Factory Method 
- Abstract Factory.

Terms of reference.

The technical task: Exporting documents
A software tool is required that allows users to export data from the system in various formats such as XML and CSV. The program should be written in C# and should generate documents in these formats based on user input.

Requirements:

- The program should prompt the user to select a format for exporting the data.
- The program must be able to generate XML and CSV documents.
- The program must use the Factory Method and Abstract Factory design templates to create documents.
- The program must use the appropriate concrete factory to create the selected document format.
- The program must be able to handle errors and invalid user inputs.
Deliverables:
- A C# program that creates documents in XML and CSV formats using the Factory Method and Abstract Factory design patterns.
- Code documentation and comments for easy maintenance and future development.
- Unit tests to ensure that the program works properly.
Restrictions:

- The program must use the Factory Method and Abstract Factory design patterns.
- The program must be able to create XML and CSV documents.
- The program must handle errors and invalid user data.
- The program must be tested and documented to ensure quality and maintainability.

In this program, we have two abstract products: Document and DocumentFactory. The concrete products are XmlDocument and CsvDocument, and the concrete factories are XmlDocumentFactory and CsvDocumentFactory.

The Factory method is implemented in the DocumentExporter class, which takes a DocumentFactory object as a parameter and uses it to create a Document object, which is then used to create a document.

In the Main method, the user is prompted to select a format for exporting data, and based on the user's choice, the corresponding Concrete Factory is created. Then an instance of the DocumentExporter is created with the selected factory, and the Export method is called to create the document in the selected format.





Розробити технічне завдання. Показати декомпонування завдання, де частина завдань має бути реалізована з використанням породжуючих патернів:
-	Фабричний метод (Factory Method) 
-	Абстрактна фабрика (Abstract Factory).

Технічне завдання

Технічне завдання: Експорт документів
Потрібен програмний інструмент, який дозволяє користувачам експортувати дані з системи в різних форматах, таких як XML і CSV. Програма повинна бути написана на мові C# та має генерувати документи в цих форматах на основі введення користувача.

Вимоги:

•	Програма має запропонувати користувачеві вибрати формат для експорту даних.
•	Програма повинна мати можливість створювати документи XML і CSV.
•	Програма має використовувати шаблони проектування Factory Method і Abstract Factory для створення документів.
•	Програма повинна використовувати відповідний бетонний завод для створення вибраного формату документа.
•	Програма повинна бути в змозі обробляти помилки та недійсні введення користувача.
Результати роботи:
•	Програма C#, яка створює документи у форматах XML і CSV за допомогою шаблонів проектування Factory Method і Abstract Factory.
•	Документація коду та коментарі для зручного обслуговування та майбутнього розвитку.
•	Модульні тести, щоб переконатися, що програма працює належним чином.
Обмеження:

•	Програма повинна використовувати шаблони проектування Factory Method і Abstract Factory.
•	Програма повинна вміти створювати документи XML і CSV.
•	Програма має обробляти помилки та недійсні дані користувача.
•	Програма має бути перевірена та задокументована для забезпечення якості та придатності до обслуговування.

У цій програмі ми маємо два абстрактні продукти: Document і DocumentFactory. Конкретні продукти — це XmlDocument і CsvDocument, а бетонні заводи — XmlDocumentFactory і CsvDocumentFactory.

Метод Factory реалізований у класі DocumentExporter, який приймає об’єкт DocumentFactory як параметр і використовує його для створення об’єкта Document, який потім використовується для створення документа.

У методі Main користувачеві пропонується вибрати формат для експорту даних, і на основі вибору користувача створюється відповідний Concrete Factory. Потім екземпляр DocumentExporter створюється з вибраною фабрикою, а метод Export викликається для створення документа у вибраному форматі.

using TODO_App;

var todos = new List<string>();

Console.WriteLine("Hello!");

bool shallExit = false;
while (!shallExit)
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var userChoise = Console.ReadLine();

    switch (userChoise)
    {
        case "E":
        case "e":
            shallExit = true;
            break;

        case "S":
        case "s":
            SeeAllTodos();
            break;

        case "A":
        case "a":
            AddTodo();
            break;

        case "R":
        case "r":
            RemoveTodo();
            break;

        default:
            Console.WriteLine("Invalid choice");
            break;

    }
}

Console.ReadKey();

void AddTodo()
{
    bool isValidDescription = false;
    while (!isValidDescription)
    {
        Console.WriteLine("Enter the TODO description");
        var description = Console.ReadLine();

        if (description == "") Console.WriteLine("The description cannot be empty");
        if (todos.Contains(description)) Console.WriteLine("The description mus be unique");
        else
        {
            isValidDescription = true;
            todos.Add(description);
        }

    }
}

void SeeAllTodos()
{
    if (todos.Count == 0) ShowNoTodos();
    else
    {
        for (int i = 0; i < todos.Count; i++)
        {
            string? todo = todos[i];
            Console.WriteLine($"{i + 1}. {todos[i]}");
        }
    }
}

void RemoveTodo()
{
    if (todos.Count == 0)
    {
        ShowNoTodos();
        return;
    }

    bool isIndexValid = false;
    while (!isIndexValid)
    {
        Console.WriteLine("Seect the index of the ToDO you want to remove");
        SeeAllTodos();
        var userInput = Console.ReadLine();
        if (userInput == "")
        {
            Console.WriteLine("Selected index cannot be empty");
            continue;
        }
        if (int.TryParse(userInput, out int index) && index >= 1 && index <= todos.Count)
        {
            var indexOfTodo = index - 1;
            var todoToBeRemoved = todos[indexOfTodo];
            todos.RemoveAt(indexOfTodo);
            isIndexValid = true;
            Console.WriteLine("TODO removed: " + todoToBeRemoved);
        }
        else { Console.WriteLine("The given index is not valid"); }
    }

}
static void ShowNoTodos()
{
    Console.WriteLine("No TODOs have been added yet.");
}

int number = 10;
number *= 20;

var stiangle = new Triangle(5, 6);
stiangle.AsString();
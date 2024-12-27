namespace OOP1;

internal abstract class Program
{
    private static void Main()
    {
        Ex3();
    }

    private static void Ex1()
    {
        Animal dog = new Dog();
        dog.MakeSound();
        dog.Eat();
        ((IRunnable)dog).Run();

        Animal cat = new Cat();
        cat.MakeSound();
        cat.Eat();
        ((IRunnable)cat).Run();

        Console.WriteLine("--------------------------------");
        Animal[] animals = { dog, cat };

        foreach (var a in animals)
        {
            a.MakeSound();
            a.Eat();
            ((IRunnable)a).Run();
        }
    }

    private static void Ex2()
    {
        Manager manager = new Manager("Manager name", "Sales");
        Console.WriteLine(manager);

        Employee managerAsEmployee = new Manager("Manager name as employee", "Sales");
        Console.WriteLine(managerAsEmployee);

        Employee employee = new Employee("Employee name");
        Console.WriteLine(employee);

        Console.WriteLine("--------------------------------");
        Employee[] employees = { manager, managerAsEmployee, employee };

        foreach (var e in employees)
        {
            Console.WriteLine(e);
        }
    }

    private static void Ex3()
    {
        Mammal mammal = new Mammal
        {
            Name = "Mammal",
            FurColor = "Brown",
        };

        Bird bird = new Bird
        {
            Name = "Bird",
            FlyType = "Flying",
        };

        Parrot parrot = new Parrot
        {
            Name = "Kesha",
            FlyType = "Swooping",
            Vocabulary = "Chirp"
        };

        BaseAnimal[] animals = { mammal, bird, parrot };

        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }
}

// Abstract Product
public abstract class Document
{
    public abstract void Generate();
}

// Concrete Product 1
public class XmlDocument : Document
{
    public override void Generate()
    {
        Console.WriteLine("Generating XML document...");
    }
}

// Concrete Product 2
public class CsvDocument : Document
{
    public override void Generate()
    {
        Console.WriteLine("Generating CSV document...");
    }
}

// Abstract Factory
public abstract class DocumentFactory
{
    public abstract Document CreateDocument();
}

// Concrete Factory 1
public class XmlDocumentFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new XmlDocument();
    }
}

// Concrete Factory 2
public class CsvDocumentFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new CsvDocument();
    }
}

// Factory Method
public class DocumentExporter
{
    private DocumentFactory _factory;

    public DocumentExporter(DocumentFactory factory)
    {
        _factory = factory;
    }

    public void Export()
    {
        Document doc = _factory.CreateDocument();
        doc.Generate();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose a format to export data:");
        Console.WriteLine("1. XML");
        Console.WriteLine("2. CSV");

        int choice = Convert.ToInt32(Console.ReadLine());

        DocumentFactory factory;
        switch (choice)
        {
            case 1:
                factory = new XmlDocumentFactory();
                break;
            case 2:
                factory = new CsvDocumentFactory();
                break;
            default:
                throw new ArgumentException("Invalid choice");
        }

        DocumentExporter exporter = new DocumentExporter(factory);
        exporter.Export();

        Console.ReadKey();
    }
}

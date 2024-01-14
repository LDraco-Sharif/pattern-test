// See https://aka.ms/new-console-template for more information
using Pattern_Test.Patterns.AbstractFactory;
using Pattern_Test.Patterns.AbstractFactory.AbstractComponents;
using Pattern_Test.Patterns.AbstractFactory.Factory;
using Pattern_Test.Patterns.Factory;
using Pattern_Test.Patterns.Factory.ChildComponents;
using Pattern_Test.Patterns.Singleton;

LoggerSingleton logger = LoggerSingleton.getInstance();
logger.addData("Data");


//Singleton
//ReaderSingleton reader2 = ReaderSingleton.getInstance();
//reader2.addData("Data 2");

//Factory
//FactoryComponent component1 = new CsvReader();
//FactoryComponent component2 = new XmlReader();
//component1.addMessage("This is from component 1");
//component2.addMessage("This is from component 2"); 

//Abstract Factory
AbstractFactoryComponent csv = new Csv();
AbstractFactoryComponent xml = new Xml();

Reader csvReader = csv.createReader();
Writer csvWriter = csv.createWriter();
Reader xmlReader = xml.createReader();
Writer xmlWriter = xml.createWriter();

csvReader.read("CSV Reader 1");
csvWriter.write("CSV Writer 1");
xmlReader.read("XML Reader 1");
xmlWriter.write("XML Writer 1");

logger.showAll();
// See https://aka.ms/new-console-template for more information
using Pattern_Test.Patterns.Factory;
using Pattern_Test.Patterns.Factory.ChildComponents;
using Pattern_Test.Patterns.Singleton;

ReaderSingleton reader = ReaderSingleton.getInstance();
//ReaderSingleton reader2 = ReaderSingleton.getInstance();
reader.addData("Data");
//reader2.addData("Data 2");


FactoryComponent component1 = new CsvReader();
FactoryComponent component2 = new XmlReader();

component1.addMessage("This is from component 1");
component2.addMessage("This is from component 2"); 

reader.showAll();
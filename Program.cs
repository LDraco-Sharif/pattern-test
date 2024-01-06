// See https://aka.ms/new-console-template for more information
using Pattern_Test.Patterns;

ReaderSingleton reader = ReaderSingleton.getInstance();
ReaderSingleton reader2 = ReaderSingleton.getInstance();
reader.addData("Data");
reader2.addData("Data 2");
reader.showAll();

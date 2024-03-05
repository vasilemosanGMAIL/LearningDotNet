// See https://aka.ms/new-console-template for more information
using AdvancedTopics;

Console.WriteLine("*************C# Events*********");
var video = new Video() { Title = "Video 1"};
var videoEncoder = new VideoEncoder();//publisher
var mailService = new MailService();// subscriber
var messageService = new MessageService();// another subscriber

videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
videoEncoder.Encode(video);

Console.WriteLine("\n*************C# Extension methods*********\n");
string post = "This is supposed to be a very long blog post blah blah blah...";
var shortenedPost = post.Shorten(5);
Console.WriteLine(shortenedPost);

Console.WriteLine("\n*************C# LINQ*********\n");
var books = new BookRepository().GetBooks();

//creating a list of cheap books without LINQ
//var cheapBooks = new List<Book>();
//foreach (var book in books)
//{
//    if (book.Price <=10)
//        cheapBooks.Add(book);
//}

// LINQ Query Operators
var cheaperBooks = 
    from b in books
    where b.Price < 10
    orderby b.Title
    select b.Title;

// creating a list of cheap books  LINQ
var cheapBooks = books.Where(b => b.Price < 10).OrderBy(b => b.Title);

foreach (var book in cheaperBooks)
    Console.WriteLine(book);

//LINQ Extension Methods //SingleOrDefault will not crash if no result is found
var book1 = books.SingleOrDefault(book => book.Title == "ASP.Net MVC++");
Console.WriteLine("Book1: " + book1);

// this will skip the first 2 books and take last 3
var book2 = books.Skip(2).Take(3);
foreach (var book in book2)
    Console.WriteLine(book.Title);

Console.WriteLine("LINQ count rezult: " + book2.Count());
Console.WriteLine("Max value in colletion " + book2.Max(b => b.Price));

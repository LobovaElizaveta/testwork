string[] massive ={"1", "bb3", "Russia", "it", "w3e4"};

var result = new string[massive.Length];
var length = 0;
foreach(var element in massive)
{
    if( element.Length <=2)
    {
        result[length]=element;
        length++;
    }
}
Console.WriteLine(String.Join(" ", result));
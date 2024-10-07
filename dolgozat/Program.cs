
using dolgozat;
using System.Text;

List<Verseny> versenyzo = [];
using StreamReader sr = new(
    path: "forras.txt",
    encoding: Encoding.UTF8
    );

while (!sr.EndOfStream) versenyzo.Add(new(sr.ReadLine()));

Console.WriteLine($"{versenyzo.Count} versenyző fejezte be a versenyt");

var elitbe = versenyzo.Where(v => v.Category == "elit").Count();
Console.WriteLine($"versenyzők száma 'elit' kategóriában: {elitbe}");

var nokatlageletkora = versenyzo.Where(v => v.Sex == "n").Average(v => DateTime.Now.Year - v.Birthdate);
Console.WriteLine($"női versenyzők átlagéletkora: {nokatlageletkora}");

var kerekparido = versenyzo.Sum(v => v.Cycling.TotalHours);
Console.WriteLine($"a versenyzők kerékpározással töltött összideje: {kerekparido:0.00}");

var elituszas = TimeSpan.FromSeconds(versenyzo.Where(v => v.Category == "elit junior").Average(v => v.Swimtime.TotalSeconds));
Console.WriteLine($"átlagos úszási idő elit junior kategóriában: {elituszas}");


var kategoriankent = versenyzo.GroupBy(v => v.Category);
Console.WriteLine($"korkategóriánként a versenyt befejezők száma: ");
foreach (var v in kategoriankent)
{
    Console.WriteLine($"{v.Key} : {v.Count()}");
}


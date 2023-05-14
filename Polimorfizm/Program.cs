namespace Polimorfizm;
class Program
{
    static void Main(string[] args)
    {
        // Vehicle veh = new Vehicle();
        // Console.WriteLine(veh.GetVehicleType());

        Train tr = new Train("electric", 120);
        Console.WriteLine(tr.GetVehicleType());
        Console.WriteLine(tr); 
    }
}

// Słowo polimorfizm ma wiele znaczeń. W programowaniu obiektowym jest to
//  jeden z paradygmantów, który najczęściej jest wyrażany jako „jeden interfejs, wiele funkcji”.
// Polimorfizm może być statyczy i dynamiczny. W polimorfizmie statycznym odpowiedź funkcji jest 
//  określna w trakcie kompilowania. W polimorfizmie dynamicznym odpowiedź ta jest podejmowana w czasie wykonywania programu.

// Polimorfizm statyczny: Mechanim łączenia metody z obiektem w trakcie kompilacji jest nazywany wczesnym wiązaniem lub też statycznym wiązaniem. 
// C# udostępnia dwa sposoby implementowania statycznego polimorfizmu:
// przeciążanie metod;
// przeciązanie operatorów.

// Przeciążenie metod:
//  Pisze się dwie funkcje, które pobierają różne zmienne typu int, float, string i później nie ma problemów przy wywoływaniu tej funkcji

// Przeciążenie operatorów
// C# pozwala na zmianę lub przeciążenie większości wbudowanych operatorów. Programista może używać operatorów z typami zdefiniowanymi 
// również przez użytkownika. Przeciążone operatory to metody z nazwą, słowem kluczowym operator, 
// po którym występuje symbol operatora, który chcemy zdefiniować. Przeciążony operator ma typ zwracany oraz listę parametrów.

// Operatory przeciążalne i nieprzeciążalne
// +, -, !, ~, ++, --	operatory jednoargumentowe mogą zostać przeciążone
// +, -, *, /, %	operatory binarne mogą zostać przeciążone
// ==, !=, <,>, <=, >=	operatory porównania mogą zostać przeciążone
// &&, ||	operatory operacji logicznych nie mogą być przeciążone bezpośrednio
// +=, -=, *=, /=, %=	operatory przypisania nie mogą być przeciążone
// =, ., ?:, ->, new, is, sizeof, typeof	te operatory nie mogą być przeciążone
/*        public static Pudelko/bool operator +(Pudelko a, Pudelko b)
        {
            Pudelko pud = new Pudelko();
            pud.wysokosc = a.wysokosc + b.wysokosc;
            pud.szerokosc = a.szerokosc + b.szerokosc;
            pud.dlugosc = a.dlugosc + b.dlugosc;
            return pud;
        }
*/
// https://www.plukasiewicz.net/CSharp_dla_poczatkujacych/Polimorfizm

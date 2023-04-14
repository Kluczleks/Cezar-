//deklarujemy funkcje zwracajacą stringa i przyjmujaca stringa jako argument
string toAsciiCaesar(String clearText)
{
    //zamieniamy na wielkie litery
    clearText = clearText.ToUpper();
    //iteruj przez cały tekst litera po literze
    //deklarujemy string wynikowy
    string encryptedText = "";
    foreach (char c in clearText)
    {
        //pomiń wszystkie znaki poza literami z alfabetu łacińskiego
        if (c >= 65 && c <= 90)
        {
            //wyciągamy kod ascii danej liery
            //w języku c# rzutowanie jawne z char na int powoduje pobranie wartości ascii
            int asciiCode = (int)c;
            //dodajemy wartośc klucza
            asciiCode += 3;
            //sprawdzamy czy nie przekroczxyliśmy ostatniego znaku (z, 90)
            if (asciiCode > 90)
                //jeśli przekroczyło to cofnij o długość alfabetu
                asciiCode -= 26;
            //zamianiamy kod z powrotem na znak
            char encryptedChar = (char)asciiCode;
            //dopisujemy do szyfru
            encryptedText += encryptedChar;
        }// zwroc zakodowant string
    } return encryptedText;
}

string fromAsciiCaesar(string encryptedText)
{
    string clearText = "";
    clearText = clearText.ToUpper();
    foreach (char c in encryptedText)
    {
        //pomiń wszystkie znaki poza literami z alfabetu łacińskiego
        if (c >= 65 && c <= 90)
        {
            //wyciągamy kod ascii danej liery
            //w języku c# rzutowanie jawne z char na int powoduje pobranie wartości ascii
            int asciiCode = (int)c;
            //dodajemy wartośc klucza
            asciiCode -= 3;
            //sprawdzamy czy nie przekroczxyliśmy ostatniego znaku (z, 90)
            if (asciiCode > 90)
                //jeśli przekroczyło to cofnij o długość alfabetu
                asciiCode -= 26;
            //zamianiamy kod z powrotem na znak
            char encryptedChar = (char)asciiCode;
            //dopisujemy do szyfru
            encryptedText += encryptedChar;
        }// zwroc zakodowant string
         //todo: napisz funkcj 
        string uncryptedText = "";
        //zwróc wartość


    }
    return encryptedText;
}


    //zdefiniuj string do zaszyfrowania
    string clearText = "Ala ma kota, kot ma Ale, a sierotka ma rysia";

Console.WriteLine("Zaszyfrowany tekst: " + fromAsciiCaesar(clearText));

//slownik do szyfrowania

const string chars = "AĄBCĆDEĘFGHIJKLŁMNŃOÓPRSŚTUVWXYZŹŻ ";

string toArrayCaesar(string clearText)
{   //zmień tekst na wielkie litery 
    clearText = clearText.ToUpper();
    string encryptedText = "";
    //deklarujemy tablicę pojedyńczych charów i wypełniamy ją ze słownika 
    char[] charArray = chars.ToCharArray();
    //przechodzimy pętlą przez tekst do zaszyfrowania 
    foreach(char c in clearText)
    {
        //znajdujem pozycje w słownkiku pierwotnej (nie zaszyfrowanej) litery 
        int index = Array.IndexOf(charArray, c);
        //dodajemy wartość klucza 
        index += 3;
        //jzeli wynikowy index jest wyższy niż liczba liter w słowniku 
        if (index > charArray.Length - 1)
        {       
            //odejmij długość słownika żeby go "zawinąć"
            index -= charArray.Length;
        }
        encryptedText += charArray[index];
    }


    return encryptedText;
}

//zdefiniuj tekst

string encryptedText2 = toArrayCaesar(clearText);
Console.WriteLine("Zaszyfrowany drugą metodą tekst: " + encryptedText2);
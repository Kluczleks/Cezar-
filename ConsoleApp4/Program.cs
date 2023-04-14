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
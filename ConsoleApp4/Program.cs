//zdefiniuj string do zaszyfrowania
string clearText = "Ala ma kota, kot ma Ale, a sierotka ma rysia";
//zamieniamy na wielkie litery 
clearText = clearText.ToUpper();

//iteruj przez cały tekst litera po literze 
//deklarujemy string wynikowy 
string encryptedText = " ";
foreach (char c in clearText)
{
    //wyciagamy kod asci danej litery
    // w języku c# rzutowanie jawne z char z int powodyhe pobranie wartosci ascii
    int asciiCode = (int)c;
   //dodajemy wartość klucza 
    asciiCode += 3;
    //zamieniamy kod z powrotem na znak 
    char encryptedChar = (char)asciiCode;
    //dopisujemy do szyfru
    encryptedText += encryptedChar;
}

Console.WriteLine("Zaszyfrowany tekst: " + encryptedText);
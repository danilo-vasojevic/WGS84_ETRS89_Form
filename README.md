# WGS84_ETRS89_Form
Simple Windows Form App to translate some coordinates.

## External libraries
Ovaj projekat koristi implementaciju dve eksterne biblioteke. Prvu za učitavanje podataka, dok druga biblioteka donosi moćne funkcije za matematičke proračune.
### Math.NET Numberics
**Link**: 
https://numerics.mathdotnet.com/

**Description**: 
Math.NET Numerics aims to provide methods and algorithms for numerical computations in science, engineering and every day use. Covered topics include special functions, linear algebra, probability models, random numbers, interpolation, integration, regression, optimization problems and more.
### FileHelpers
**Link**: 
http://www.filehelpers.net/

**Description**: 
FileHelpers is a free and easy to use .NET library to import or export data from fixed length or delimited records in files, strings or streams.
You can strongly type your flat file (fixed or delimited) by simply describing a class that maps to each record and later read or write your file as a strongly typed .NET array.

## Opis fajlova
U nastavku je kratak opis fajlova koji su dodati ručno, modifikovani i nisu automatski generisani od strane Visual Studio okruženja tokom kreacije projekta ili korišćenjem Web Form dizajner funkcionalnosti pomenutog okruženja.
### App.config
**Link**: https://msdn.microsoft.com/en-us/library/windows/desktop/aa374182(v=vs.85).aspx

**Description**: An application configuration file is an XML file used to control assembly binding. It can redirect an application from using one version of a side-by-side assembly to another version of the same assembly. This is called per-application configuration. An application configuration file applies only to a specific application manifest and dependent assemblies

**U ovoj aplikaciji**: U ovoj aplikaciji, koristi se samo jedna od mnogobrojnih primena konfiguracionog fajla. Koristi se AppSettings deo, koji je set (_ključ_, _vrednost_) parova koji se mogu čitati u toku rada aplikacije. U našem slučaju, vrednosti u konfiguracionom fajlu su neke podrazumevane(_default_) vrednosti koje se postavljaju, na primer, u tekstualna polja pri učitavanju(_load_) forme u toku pokretanja. To su sledeće crednosti:

 Ključ | Vrednost | Opis 
 ----- | -------- | -----
aDefaultValue  | 6378137 | Vrednost _a_ parametra
fDefaultValue  | 0.00335281066 | Vrednost _f_ parametra
ExportFileName | WGS84\_ETRS89.txt | Ime fajla za izvoz prevedenih podataka

### ConfigManager.cs
Ovaj fajl je statička(_static_) klasa omotač(_wrapper_) oko već postojeće(_built in_) Mictosoft-ove **System.Configuration.ConfigurationManager** klase koja se koristi za čitanje konfiguracionog(_*.config_) fajla. Cilj korišćenja ovog metoda je smanjenje šanse da se u toku pozivanja konfiguracionih parametara napravi greška u pisanju jer se ConfigManager klasa koristi _Property_ polja koja se pozivaju po nazivu tog polja, dok ConfigurationManager klasa koristi _lieral_ string kao parametar. Način na koji je omotač klasa napravljena se oglea na primeru:
```C#
public static string ExportFileName => ConfigurationManager.AppSettings["ExportFileName"];
```

### FileDataObject.cs
Predstavlja jedan objekat sa svim podacima koji su relevantni za jedan unos(_record_) iz ulaznog ``` *.dat ``` fajla. Ova klasa je označena, koristeći atribute(deklarativne oznake) koje nudi _FileHelpers_ biblioteka. Na taj način se definiše koja će polja tokom čitanja fajla _FileHelperEngine_ objekat, kreiran za _FileDataObject_ tip očekivati kada se pozove metoda za čitanje fajla. Ovo označavanje se vrši kroz sledeće atribute:
1. ``` [DelimitedRecord(" ")] ``` - Atribut koji se dodaje na klasu _FileDataObject_ i deklariše namenu klase ```FileHelperEngine<T>``` objektu. Takođe, ovaj atribut govori ```FileHelperEngine<T>``` objektu koji karakter unutar fajla koji će mu biti zadat će posmatrati kao delimetarski karakter. U ovom slučaju to je razmak _" "_. Na primeru, primena atributa nad klasom izgleda ovako:
```C#
[DelimitedRecord(" ")]
public class FileDataObject
{
  // Class implementation
}
```
2. ``` [FieldHidden] ``` - Ovaj atribut se koristi kada ```FileHelperEngine<T>``` objektu hoćemo da naglasimo da neko _Property_ polje treba izuzeti i da ono neće biti u fajlu koji će biti zadat za čitanje. Na primeru iz projekta:
```C#
[DelimitedRecord(" ")]
public class FileDataObject
{
  // ...
 [FieldHidden] public double Data_N_Calculated { get; set; }
 // ... 
}
```
Karaktetistike ```FileHelperEngine<T>``` objekta i način korišćenja će biti upisani unutar opisa _TranslationObject.cs_ fajla i klase koja ga sačinjava.

### SevenParameters.cs
Sadrži istoimenu klasu koja definiše _Property_ polja parametara koji će biti učitani čitanjem ``` *.PAR ``` fajla. Takođe, ova klasa definiše metode za čitanje fajla i učitavanje pročitanih vrednosti u _Property_ polja. Zbog ovoga, ova klasa se pozinva na _StreamReader_ klasu iz System.IO prostora imena(_namespace_).

### TranslationCalculator.cs
Ovaj fajl sadrži statičnu klasu koja definiše niz statičnih metoda za izračunavanje svih vrednosti koje će biti potrebne za translaciju koordinata. Pored **System.Math** klase koju TranslationCalculator klasa koristi statički, postoje metode koje instanciraju objekte i pozivaju metode definisane u MathNet.Numerics biblioteci.
Navešćemo primere izračunavanja nekih vrednosti korišćenjem System.Math klase definisane u .NET Framework-u, kao i korišćenjem MathNet.Numerics biblioteke.
1. System.Math:
```C#
public static double Calc_N_aBe(double a, double B_deg, double e) => a / (Sqrt(1 - (Square(e) * Square(Sin(Radians(B_deg))))));
```
2. Math.Net Numerics:
```C#
public static void Calc_X2_Y2_Z2(FileDataObject fdo, SevenParameters sp)
{
	Matrix<double> XYZ1 = DenseMatrix.OfArray(new double[,] {
		{ fdo.Data_X_Calculated },
		{ fdo.Data_Y_Calculated },
		{ fdo.Data_Z_Calculated }
	});
	Matrix<double> RxMi = get_RxMi(sp.Epsilon_X, sp.Epsilon_Y, sp.Epsilon_Z, sp.Mi);
	Matrix<double> Tm = DenseMatrix.OfArray(new double[,] {
		{ sp.T_X },
		{ sp.T_Y },
		{ sp.T_Z }
	});

	Matrix<double> SolutionMatrix = RxMi.Multiply(XYZ1).Add(Tm);

	fdo.Data_X2_Calculated = SolutionMatrix[0, 0];
	fdo.Data_Y2_Calculated = SolutionMatrix[1, 0];
	fdo.Data_Z2_Calculated = SolutionMatrix[2, 0];
}
```

### TranslationObject.cs
Ovaj fajl istoimenu klasu koja sadrži polja za sve relevantne podatke vezane za translaciju koordinata. Takođe, definiše metode za učitavanje podataka i njihov izvoz manipulišući direktno sa Windows Form objektima(_TextBox_, _ListBox_, _BindingSource_ i slično).

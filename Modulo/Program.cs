int a = 90;
int b = 29;
int modulo1 = a % b; //the reminder of a / b 
Console.WriteLine(modulo1); //3

int modulo2 = a % 2; // שארית מהחלוקה של איי ב 2

bool isEven = (a % 2) == 0; // כאן יש לנו ביטוי לוגי שבודק אם המספר איי הוא זוגי

/*****************
 * חישוב שארית לבד
 * ***************/

int result = a / b;
int c = b * result;
int modulo = a - c;
Console.WriteLine(modulo);

/*****************
 * תרגיל כיתה על ביטויים לוגיים
 * ***************/

Console.WriteLine("Pick first number");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Pick second number");
int num1 = int.Parse(Console.ReadLine());

bool b1 = num == num1;
bool b2 = num > num1;
bool b3 = num1 <= num;

Console.WriteLine(b1);
Console.WriteLine(b2);
Console.WriteLine(b3);














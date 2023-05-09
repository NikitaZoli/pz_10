// See https://aka.ms/new-console-template for more information
using System.Text;

string S = "lol";
char C = 'o';
System.Text.StringBuilder T = new StringBuilder();
CharEnumerator N = S.GetEnumerator();
while (N.MoveNext())
{
    char i = N.Current;
    T.Append(i);
    if (i == C) T.Append(i);
}
S = T.ToString();
Console.WriteLine(S);

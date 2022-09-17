using static System.Console;

Clear(); 
// SetCursorPosition(10, 4);
// WriteLine("+"); 
int xa = 45, ya = 1, 
xb = 1, yb = 30, 
xc = 90, yc = 30; 

SetCursorPosition(xa, ya);
WriteLine("+");
SetCursorPosition(xb, yb);
WriteLine("+");
SetCursorPosition(xc, yc);
WriteLine("+");
int x=xa, y=xb;
int count=0;
while(count<10000)
{
    int what=new Random().Next(0, 3);

if (what==0)
{
x=(x+xa)/2;
y=(y+ya)/2;
}
if (what==1)
{
x=(x+xb)/2;
y=(y+yb)/2;
}
if (what==2)
{
x=(x+xc)/2;
y=(y+yc)/2;
}
SetCursorPosition(x, y);
WriteLine("+");
count++;
}
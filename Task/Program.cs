int MaxNum(int x, int y)
{
    if(x > y)
{
    return x;
}
else return y;
}

int xx = 3;
int yy = 2;
int maxn = MaxNum(yy, xx);
Console.WriteLine($"{maxn} больше");

int x1 = 3;
int y1 = 7;
MaxNum(x1, y1);
int maxn1 = MaxNum(y1, x1);
Console.WriteLine($"{maxn1} больше");

// int x2 = 17;
// int y2 = 5;
// MaxNum(x2, y2);


// void HelloWorld(string name)
// {
//     Console.WriteLine($"Привет, {name}!!!!!");
// }

// string q = "Bob";
// HelloWorld(q);
// string a = "Ann";
// HelloWorld(a);
// string z = "Alise";
// HelloWorld(z);



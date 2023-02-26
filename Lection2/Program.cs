int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 3981;
int b1 = 401331;
int c1 = 9567;
int a2 = 3100;
int b2 = 4232;
int c2 = 9660;
int a3 = 3821;
int b3 = 4408;
int c3 = 9060;

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);
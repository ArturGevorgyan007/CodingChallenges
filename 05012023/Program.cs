int n = Int32.Parse(Console.ReadLine());

int func(int n) {
    int step = 0;
    while(n!=1) {
        if(n%2==0) 
            n=n/2;
        else
            n=3*n+1;
        step++;      
    }
    return step;
}

Console.WriteLine(func(n));

// See https://aka.ms/new-console-template for more information

int n = 8;
for (int i = 0; i < n; i++)
{   
    String stars = "";
    for (int j = 0; j < n; j++) 
    {
        if (j == i || j == 0 || j == n-1 || j == n - i -1 || i == 0 || i == n-1) {
            stars += "*";
        } else { 
            stars += " "; 
        }
    }
    
    Console.WriteLine(stars);
}

#include <stdio.h>
#include <math.h>
main()
{
    int a, b, c;

    printf("Calcul des solutions reelles d'une équation du second \n");
    printf("degre sous la forme  ax^2 + bx + c = 0 \n\n");

    saisie(a, b, c);

    calcul(a, b, c);
}


void saisie(float* a, float* b, float* c)
{
    printf("Ebntrer les valeurs pour a, b, et c : \n");

    printf("\na : ");
    scanf("%i", &a);

    printf("\nb : ");
    scanf("%i", &b);

    printf("\nc : ");
    scanf("%i", &c);
}

void calcul(float a, float b, float c)
{
    double d;
    d = pow(b, 2) - 4.0 * a * c;

    if (a == 0 && b == 0 && c == 0) 
        printf("Tous les réels sont une solution pour cette equation.\n");
    else if (a == 0 && b == 0) 
        printf("Cette equation ne dispose pas de solution.\n");
    else if (a == 0) 
    {
        printf("La solution de cette equation du premier degre est :\n");
        printf(" x = %.4f\n", (double)c / b);
    }
    else if (d < 0) 
        printf("Cette equation ne dispose pas de solution reelles.\n");
    else if (d == 0)
    {
        printf("Cette equation ne dispose pas de solution reelle :\n");
        printf(" x =  %.4f\n", (double)-b / (2 * a));
    }
    else 
    {
        printf("Les solutions reelles de cette equation sont :\n");
        printf(" x1 = %.4f\n", (-b + sqrt(d)) / (2 * a));
        printf(" x2 = %.4f\n", (-b - sqrt(d)) / (2 * a));
    }
    return 0;
}
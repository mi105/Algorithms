#include <stdio.h>
#include <string.h>

typedef struct Map
{
    char x;
    char z;
} Map;

int AreStringsIsomorphic(char* a, char* b )
{
int i,j;
int alen = strlen(a);
int blen = strlen(b);
int len = alen < blen ? alen : blen;

Map M[len];

for(i=0; i<len; i++)
{
    M[i].x = '\0';
    M[i].z = '\0';
}

int indicator;

for(i=0; i<alen; i++)
{
    for (j=0; j<blen; j++)
    {
        //Map m = find(M, a[i]);
        
    }
}

return 0;
}

int main()
{
    char *a = "milos";
    char *b = "petar";
    int i = AreStringsIsomorphic(a,b);
    printf("%d\n", i);

    return 0;
}

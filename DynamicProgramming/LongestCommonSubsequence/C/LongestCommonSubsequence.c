#include <stdio.h>
#include <string.h>
int main(){
    
    char a[100];
    char b[100];
    int a_len;
    int b_len;
    
    printf("Enter string A\n");
    scanf("%s", a);
    a_len = strlen(a);
    
    printf("Enter string B\n");
    scanf("%s", b);
    b_len = strlen(b);
    
    int  LCS[a_len+1][b_len+1];
    int i=0, j=0;
    
    for(i=0; i<=a_len; i++)
        LCS[i][0] = 0;
    for(j=0;j<=b_len; j++)
        LCS[0][j] =0;
    
    for (i=1; i<=a_len; i++)
        for (j=1; j<=b_len; j++)
            if(a[i-1]==b[j-1])
                LCS[i][j] = 1+ LCS[i-1][j-1];
            else
                LCS[i][j] = LCS[i][j-1] > LCS[i-1][j] ? LCS[i][j-1] : LCS[i-1][j]; 
                
    printf("   ");
    for (j=0; j<=b_len; j++)
        if(j>0)
            printf("%c, ", b[j-1]);
        else 
            printf ("_, ");
    printf("\n");

        
    for (i=0; i<=a_len; i++)
    {
        if(i>0)
            printf("%c, ", a[i-1]);
        else 
            printf ("_, ");
        for (j=0; j<=b_len; j++)
        {
            printf("%d, ",LCS[i][j]);
        }
        printf("\n");
    }
        
    return 0;
}

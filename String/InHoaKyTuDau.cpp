#include<stdio.h>

#include<string.h>

#define max 100

char InHoaKyTuDau(char s[])

{
    int i;
    if(s[0]!=' ')
    {
    s[0]=s[0]-32;
    for(i=1;i<strlen(s);i++)
    {
        if(s[i]==' ' && s[i+1]!=' ' && s[i+1]>='a' && s[i+1]<='z' )
        {
            s[i+1]=s[i+1]-32;
        }          
    }
    }
    else
    {
    for(i=0;i<strlen(s);i++)
    {
        if(s[i]==' ' && s[i+1]!=' ' && s[i+1]>='a' && s[i+1]<='z' )
        {
            s[i+1]=s[i+1]-32;
        }          
    }

    }

    printf("%s",s);

}

int main()

{
    char s[max];
    printf("Nhap chuoi: ");
    gets(s);
    InHoaKyTuDau(s);

}
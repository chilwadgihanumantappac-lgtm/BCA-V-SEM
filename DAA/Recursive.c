#include<stdio.h>

unsigned long long recursiveFactorial(int n)
{
	if(n==0||n==1)
	return 1;

	return n*recursiveFactorial(n-1);
	}
	int main()
	{
		int n,i;
		unsigned long long fact=1;
		
		printf("Enter a non negative integer:");
		scanf("%d",&n);
		
		if(n<0)
		{
		printf("Factorial is not defined for negativce numbers/n");
		return 0;
		}
	
		
		
		/*Iterative Method*/
		
		for(i=1;i<=n;i++)
		fact=fact*i;
		
		printf("Factorial using iterative method=%llu\n",fact);
		
		/*Recursive Method*/
		
		printf("Factorial using Recursive method =%llu\n",recursiveFactorial(n));
		return 0;
		}
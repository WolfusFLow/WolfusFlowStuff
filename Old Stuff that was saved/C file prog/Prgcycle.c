#define _CRT_SECURE_NO_WARNINGS
#include <conio.h> 
#include <stdlib.h> 
#include <stdio.h> 
#include <ctype.h> 
#include <string.h> 


void add_num(void), lookup(void);
char menu(void);

int main(void)
{
	char choice;
	do {
		choice = menu();
		switch (choice) {
		case 'a': add_num();
			break;
		case 'l': lookup();
			break;
		}
	} while (choice != 'q');
	return 0;
}

/* Ïîêàçàòü ìåíþ è çàïðîñ */
char menu(void)
{
	char ch;
	do {
		printf("(A)dd, (L)ookup, or (Q)uit: ");
		ch = tolower(_getche());
		printf("\n");
	} while (ch != 'q' && ch != 'a' && ch != 'l');
	return ch;
}

/* Äîáàâèòü èìÿ è íîìåð */
void add_num(void)
{
	FILE *fp;
	char name[80], ch;
	int a_code, exchg, num;

	/* Ðàáîòà ñ ôàéëîì */
	if ((fp = fopen("phone", "a")) == NULL) {
		printf("Cannot open directory file.");
		exit(1);
	}
	printf("Enter name and number: ");
	fscanf(stdin, "%s%d%d%d", name, &a_code, &exchg, &num);
	fscanf(stdin, "%*c"); /* Óäàëåíèå êàððåòêè âîçâðàòà èç âîîäà */

						  /* Çàïèñü â ôàéë */
	fprintf(fp, "%s %d %d %d", name, a_code, exchg, num);
	fclose(fp);
}

/* ïîèñê ïî èìåíè */
void lookup(void)
{
	FILE *fp;
	char name[80], name2[80], ch;
	int a_code, exchg, num;

	/* Îòêðûòèå äëÿ ñ÷èòûâàíèÿ */
	if ((fp = fopen("phone", "r")) == NULL) {
		printf("Cannot open directory file.");
		exit(1);
	}
	printf("name or letter? ");
	gets(name);

	/* Ïîèñê íîìåðà */
	while (!feof(fp)) 
	{
		fscanf(fp, "%s%d%d%d", name2, &a_code, &exchg, &num);
		if (!strcmp(name, name2)) {
			printf("%s: (%d) %d-%d\n", name, a_code, exchg, num);
			break;
		}
		else
			ch = name[0];
 
		for	(int i = 0; i<2 ; i++)
		{
			if ((ch < name2) & (ch == name2[0]))
			{

				printf("%s: (%d) %d-%d\n", name2, a_code, exchg, num);
				break;
			}
			break;
		}

	}
	
		fclose(fp);
}
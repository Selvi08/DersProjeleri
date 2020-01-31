#include <stdio.h>  
#include <stdlib.h>
#include <math.h>
#include <time.h>
#include "sqlite3.h"

sqlite3 * db;
const char *filename = "database.db";
int rc;
char * zErrMsg = 0;
int nerden,nereye,bilet_adedi,toplam;

void openDb()
{
	rc = sqlite3_open(filename, &db);
	if( rc != SQLITE_OK){
		fprintf(stderr, "Can't open database: %s\n", sqlite3_errmsg(db));
		//exit(0);
	}
	else{
		fprintf(stderr, "Opened database successfully\n");
	}
	
	sqlite3_close(db);
	printf("\n\n");
}
int  bilet()
{
	int secim;
	
	printf("Ana Ekran\n");
	printf("-----------------\n\n");
	printf("1-)Bilet Satis\n\n");
	printf("2-)Bilet Iade\n\n");
	printf("3-)Cikis Yap\n\n");
	printf("islem tipini seciniz...\n\n");
	scanf("%d",&secim);  
	
	return secim;
}

int secim()
{
	//int nerden,nereye,bilet_adedi;
	
	printf("Bilet Satis\n");
	printf("-----------------\n\n");
	printf("nerden\n\n");
	scanf("%d",&nerden);
		if(nerden<1 || nerden>38) 
     	{
	    	printf("nerden veya nereye 1 ile 38 arasi secilebilir!\nLutfen tekrar deneyiniz..\n\n");	
	    	return -1;
    	}
    	 if(nerden==nereye)
	     {
	     	printf("Ayni Durak Secilemez!\nLutfen tekrar deneyiniz..\n\n"); 
	     	return -1;
		 }	     
	
	printf("nereye\n\n");
	scanf("%d",&nereye);
		if(nereye<1 || nereye>38)
     	{
	    	printf("nerden veya nereye 1 ile 38 arasi secilebilir!\nLutfen tekrar deneyiniz..\n\n");	
	    	return -1;
    	}
    	 if(nerden==nereye)
	     {
	     	printf("Ayni Durak Secilemez!\nLutfen tekrar deneyiniz..\n\n"); 
	     	return -1;
		 }	     
		 
   	printf("bilet adedi\n\n");
	scanf("%d",&bilet_adedi); 
        if(bilet_adedi>9)
     	{
	     	printf("Bilet Adedi En Fazla 9 Adet Secilebilir!\nLutfen tekrar deneyiniz..\n\n");
	     	return -1;   	
     	}
     
	return 0;	
}
void makbuz()
{
	time_t t;
    time(&t);
	
	printf("ASIS ELEKTRONIK\n");
	printf("-----------------\n\n");
    printf("Tarih/Saat: %s\n",ctime(&t));
	printf("Referans No : %d\n\n",rand());
	printf("nerden :%d\n\n",nerden);
	printf("nereye :%d\n\n",nereye);


	 	toplam=abs(nerden-nereye)*bilet_adedi;
			
		if(nerden-nereye>0 && nerden-nereye<=4)
		{
	    	printf("toplam :%0.2f",2.60*bilet_adedi);
		}
	   	else if(nerden-nereye<=8)
		{
			printf("toplam :%0.2f",2.85*bilet_adedi);
		}
	    else if(nerden-nereye<= 12)
		{
			printf("toplam :%0.2f",3.00*bilet_adedi);
		}
		else if(nerden-nereye>12)
		{
			printf("toplam :%0.2f",3.45*bilet_adedi);
		}
}
int main()
 {
 	openDb();
 	int selection = 0;
 	char temp = 0; 
 	
 	for(;;)
 	{
	 	selection = bilet();	
	 	if(selection == 1)
	 	{
	 		
	 		while(temp = 1)
	 		{
			 
	 		int ret = secim();
	 		
	 		if(ret != -1)
	 		{
		 		makbuz();
		 		getchar();
		 		printf("\n\n Ana ekrana donmek icin ENTER'a basiniz \n ");
		 		scanf("%c",&temp);
		 	
			 break;	
			}
			}	
		}
		else if (selection == 2)
		{
			getchar();
			printf("Bilet iade edildi.\n");
	 	 	printf("\n\n Ana ekrana donmek icin ENTER'a basiniz \n ");
	 		scanf("%c",&temp);		
	 	}
	 	else if (selection == 3)
		 {
	 		 printf("Cikis Yapildi.\n");
	 		 return 0;
		 }	   
 	}
 	return 0;
}

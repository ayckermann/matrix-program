using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace matriks
{
    public class Matrix
    {
        public int x,y;
        public double [,] value;

        public Matrix(int x, int y){
            this.x = x;
            this.y = y;
            this.value = new double[x,y];
        }
        public Matrix(int x, int y, double[,] value){
            this.x = x;
            this.y = y;
            this.value = value;
        }

        public void display()
        {
            for (int i = 0; i < x; i++) {
                for (int j =0; j < y; j++){
                    Console.Write(value[i,j]+" ");
                }
                Console.Write("\n");
            }
        }

        public Matrix tambahMatrix(Matrix b){
            Matrix hasil = new Matrix(x,y);
            for (int i = 0; i < x; i++) {
                for (int j =0; j < y; j++){
                    hasil.value[i,j] = value[i,j] + b.value[i,j];
                }
            }
            return hasil;
        }

        public Matrix kurangMatrix(Matrix b){
            Matrix hasil = new Matrix(x,y);
            for (int i = 0; i < x; i++) {
                for (int j =0; j < y; j++){
                    hasil.value[i,j] = value[i,j] - b.value[i,j];
                }
            }
            return hasil;
        }
    
        public Matrix kaliMatrix(Matrix b){
            if(y == b.x){
                Matrix hasil = new Matrix(x,b.y);
                for (int i = 0; i < x; i++) {
                    for (int j =0; j < b.y; j++){
                        for (int k = 0; k < y; k++){
                            hasil.value[i,j] += value[i,k] * b.value[k,j];
                            
                        }
                    }
                }
                return hasil;
            }
            else{
                throw new ArgumentOutOfRangeException(
                    "Gagal! Dimensi tidak cocok");
            }
        }
        public Matrix kaliKoefisien(double n){
            Matrix hasil = new Matrix(x,y);
            for (int i = 0; i < x; i++) {
                for (int j =0; j < y; j++){
                    hasil.value[i,j] = value[i,j] * n;
                }
            }
            return hasil;
        }
        public Matrix transpose(){
            Matrix hasil = new Matrix(y,x);
            for (int i = 0; i < x; i++) {
                for (int j =0; j < y; j++){
                    hasil.value[j,i] = value[i,j];
                   
                }
            }
            return hasil;
        }

        public Matrix minorMatrix(int a, int b){
            Matrix hasil = new Matrix(x-1,y-1);
            int a1 =0, b1=0;
         
            for (int i = 0; i < x; i++) {
                for (int j =0; j < y; j++){ 
                    if(i != a-1 && j != b-1){
                        if(b1<y-1){
                            hasil.value[a1,b1] = value[i,j];
                            b1++;
                        } 
                        if(b1==y-1){
                            b1=0;
                            a1++;   
                        }
                    }           
                }
            }
    
            return hasil;
        }
        public double detMinor(int a, int b){
            Matrix temp = minorMatrix(a,b);
            double hasil = temp.determinan();
            return hasil;

        }
        public Matrix kofaktor(){
            Matrix hasil = new Matrix(x,y);
            for(int i =0;i < x;i++){
                for(int j =0 ; j < y;j++){
                    if(i%2 ==0 && j%2 !=0){
                        hasil.value[i,j] = -1 * detMinor(i+1,j+1);
                    }
                    else if(i%2!=0 && j%2==0){
                        hasil.value[i,j] = -1 * detMinor(i+1,j+1);
                    }
                    else{
                        hasil.value[i,j] =detMinor(i+1,j+1);
                    }
                }
            }
            return hasil;
            
        }
        public Matrix adjoin(){
            Matrix hasil = kofaktor();
            return hasil.transpose();

        }

        public Matrix invers(){
            Matrix hasil = adjoin();
            double det = determinan();

            return hasil.kaliKoefisien(1/det);;
        }
        public double determinan(){
            if(x==2 && y==2){
                double hasil = (value[0,0] * value[1,1]) - (value[0,1]*value[1,0]) ; 
                return hasil;
            }
            else if(x==3 && y==3){
                double hasil =0;
                hasil = ((value[0,0] * value[1,1] * value[2,2]) + 
                        (value[0,1] * value[1,2] * value[2,0]) +
                        (value[0,2] * value[1,0] * value[2,1])) - 
                        ((value[2,0] * value[1,1] * value[0,2]) +
                        (value[2,1] * value[1,2] * value[0,0]) +
                        (value[2,2] * value[1,0] * value[0,1]))
                ;
                return hasil;
            }
            else if(x==4 && y==4){
                double hasil;
                hasil = (value[0,0] * detMinor(1,1)) -
                        (value[0,1] * detMinor(1,2)) +
                        (value[0,2] * detMinor(1,3)) -
                        (value[0,3] * detMinor(1,4));

                return hasil;
                
            }
           
            else{
                 throw new ArgumentOutOfRangeException(
                    "Gagal! Dimensi tidak cocok");
            }
        }
    }


}
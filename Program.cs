using matriks;
using static matriks.Matrix;

int[,] x = new int[3,2] {{1,2},{2,3},{1,4}};
int[,] y = new int[2,3] {{1,2,2},{2,3,1}};
int[,] z = new int[2,2] {{1,3},{4,8}};
int[,] a3 = new int[3,3] {{1,2,2},{2,3,1},{1,4,6}};
int[,] a4 = new int[4,4] {{1,2,3,4},{1,5,3,2},{1,3,5,2},{4,2,1,5}}; 
Matrix a = new Matrix(3,2,x);
Matrix b = new Matrix(2,3,y);
Matrix c = a.kaliMatrix(b);
Matrix d = new Matrix(a.x,b.y);
Matrix e = a.transpose();
Matrix f = a.kaliKoefisien(2);
Matrix g = new Matrix(3,3,a3);
int h = g.determinan();
Matrix i = g.minorMatrix(3,3);
int j  = g.detMinor(3,3);
Matrix k = new Matrix(4,4,a4);

int l = k.determinan();
Matrix m = g.invers();

Console.Write("Matrix \n");
g.display();    
Console.Write(" \n");
m.display();
Console.Write("\n");
// Console.Write(j);
// Console.Write(l);

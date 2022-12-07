using matriks;
using static matriks.Matrix;

double[,] x = new double[3,2] {{1,2},{2,3},{1,4}};
double[,] y = new double[2,3] {{1,2,2},{2,3,1}};
double[,] z = new double[2,2] {{1,3},{4,8}};
double[,] a3 = new double[3,3] {{1,2,2},{2,3,1},{1,4,6}};
double[,] a4 = new double[4,4] {{1,2,3,4},{1,5,3,2},{1,3,5,2},{4,2,1,5}};
double[,] a5 = new double[5,5] {{1,2,3,4,5},{6,7,8,9,0},{0,9,8,7,6},{5,4,2,2,1},{1,2,3,4,0}};
Matrix n = new Matrix(5,5,a5);
Matrix a = new Matrix(3,2,x);
Matrix b = new Matrix(2,3,y);
Matrix c = a.kaliMatrix(b);
Matrix d = new Matrix(a.x,b.y);
Matrix e = a.transpose();
Matrix f = a.kaliKoefisien(2);
Matrix g = new Matrix(3,3,a3);
double h = g.determinan();
Matrix i = g.minorMatrix(3,3);
double j  = g.detMinor(3,3);
Matrix k = new Matrix(4,4,a4);
Matrix p = new Matrix(2,2,z);
double l = k.determinan();
Matrix m = g.invers();
double o = p.determinan();

Console.Write("Matrix \n");
g.display();    
Console.Write(" \n");
//o.display()
Console.Write(h);
Console.Write("\n");
// Console.Write(j);
// Console.Write(l);

List<Matrix> matriks = new List<Matrix>();
